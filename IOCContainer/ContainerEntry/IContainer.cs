using IOCContainer.ServiceContainer;

namespace IOCContainer.ContainerEntry
{
    internal interface IContainerEntry
    {
        Object GetValue(IContainerService container);
    }
}
