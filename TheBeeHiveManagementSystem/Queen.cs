using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace TheBeeHiveManagementSystem
{
    class Queen : Bee, INotifyPropertyChanged
    {
        private IWorker[] workers = new IWorker[0];
        private decimal eggs;
        private decimal unnasignedWorkers;
        private bool missingWork;

        public string StatusReport { get; private set; }

        public bool CanAssignWorkers { get; private set; }
        public bool HiveIsRunning {  get; set; } = true;
        public bool OutOfHoney { get { return !HiveIsRunning; } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public Queen() : base("Queen") 
        {
            unnasignedWorkers = 3;
            eggs = 0;
            AssignBee("Egg Care");
            AssignBee("Honey Manufacturer");
            AssignBee("Nectar Collector");
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override decimal CostPerShift
        {
            get { return Constants.QUEEN_COST_PER_SHIFT; }
        }
        public override bool WorkTheNextShift()
        {
            eggs += Constants.EGGS_PER_SHIFT;

            foreach (var worker in workers) 
            {
                if (!worker.WorkTheNextShift()) missingWork = true;
            }
            HoneyVault.ConsumeHoney(Constants.HONEY_PER_UNASSIGNED_WORKER * unnasignedWorkers);
            UpdateStatusReport(missingWork);
            HiveIsRunning = base.WorkTheNextShift();
            return HiveIsRunning;
        }

        private void AddWorker(IWorker worker)
        {
            if (unnasignedWorkers >= 1)
            {
                unnasignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
                if(unnasignedWorkers > 0) CanAssignWorkers = true;
            }
        }

        public void AssignBee(string? job)
        {
            switch (job)
            {
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
            }

            UpdateStatusReport(true);
        }

        public void ReportEggConversion(decimal eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unnasignedWorkers += eggsToConvert;
            }
        }

        private void UpdateStatusReport(bool missingWork)
        {
            StatusReport = HoneyVault.StatusReport + "\n\n";
            StatusReport += $"Egg count: {eggs}\nUnnasigned workers: {unnasignedWorkers}\n";
            StatusReport += WorkerStatus("Nectar Collector") + WorkerStatus("Honey Manufacturer")
                + WorkerStatus("Egg Care");
            StatusReport += $"Total workers: {workers.Length}\n";
            if (missingWork) StatusReport += "WARNING: NOT ALL WORKERS DID THEIR JOBS ";

            OnPropertyChanged("StatusReport");
            OnPropertyChanged("CanAssignWorkers");
            OnPropertyChanged("HiveIsRunning");
            OnPropertyChanged("OutOfHoney");
        }

        private string WorkerStatus(string job)
        {
            int numberOfWorkers = 0;
            foreach (var worker in workers) 
            {
                if(worker.Job == job)  numberOfWorkers++;
            }
            return $"{numberOfWorkers} {job} bees\n";
        }
    }
}
