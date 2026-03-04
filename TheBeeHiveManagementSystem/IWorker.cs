using System;
using System.Collections.Generic;
using System.Text;

namespace TheBeeHiveManagementSystem
{
    interface IWorker
    {
        string Job { get; }
        bool WorkTheNextShift();

    }
}
