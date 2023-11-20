using IOCContainer.ContainerEntry;
using System;

namespace IOCContainer.ServiceContainer
{
    internal interface IContainerService
    {
        void Bind(Type key, IContainerEntry entry);
        void Bind<T>(IContainerEntry entry);
        Object? Resolve(Type key);
        T Resolve<T>();
    }
}
