using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCContainer.Shedule
{
    internal class ScheduleViewer
    {
        private IScheduleManager _scheduleManager;
        public ScheduleViewer(IScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }
        public void RenderSchedule()
        {
            Console.WriteLine(_scheduleManager.GetSchedule().id);
        }
    }
}
