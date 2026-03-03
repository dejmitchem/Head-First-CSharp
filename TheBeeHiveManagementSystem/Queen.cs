using System;
using System.Collections.Generic;
using System.Text;


namespace TheBeeHiveManagementSystem
{
    class Queen : Bee
    {
        private Bee[] workers = [];
        private decimal eggs;
        private decimal unnasignedWorkers;
        private bool missingWork;
        public string StatusReport;
        public bool CanAssignWorkers;


        public Queen() : base("Queen") 
        {
            unnasignedWorkers = 3;
            eggs = 0;
            AssignBee("Egg Care");
            AssignBee("Honey Manufacturer");
            AssignBee("Nectar Collector");
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
            HoneyVault.ConsumeHoney(Constants.HONEY_PER_UNNASSIGNED_WORKER * unnasignedWorkers);
            UpdateStatusReport(missingWork);
            return base.WorkTheNextShift();
        }

        private void AddWorker(Bee worker)
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
