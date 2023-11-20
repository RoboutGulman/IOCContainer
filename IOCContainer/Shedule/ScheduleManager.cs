using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCContainer.Shedule
{
    internal class ScheduleManager : IScheduleManager
    {
        public Schedule GetSchedule()
        {
            return new Schedule(1234);
        }
    }
}
