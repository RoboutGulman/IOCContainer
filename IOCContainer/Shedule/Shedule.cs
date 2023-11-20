using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCContainer.Shedule
{
    internal class Schedule
    {
        public Schedule(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
