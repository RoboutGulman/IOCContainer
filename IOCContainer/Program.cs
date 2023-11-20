using IOCContainer.Shedule;
using IOCContainer.ServiceContainer;
using IOCContainer.ContainerEntry;

namespace IOCContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var containerService = new ContainerService();
            containerService.Bind<IScheduleManager>(new GeneratorContainerEntry((_) => new ScheduleManager()));
            var manager = containerService.Resolve<IScheduleManager>();

            ScheduleViewer scheduleViewer = new(manager);
            scheduleViewer.RenderSchedule();
        }
    }
}