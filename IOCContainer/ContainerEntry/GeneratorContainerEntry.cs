using System;
using IOCContainer.ServiceContainer;

namespace IOCContainer.ContainerEntry
{
    internal class GeneratorContainerEntry : IContainerEntry
    {
        public GeneratorContainerEntry(Func<IContainerService, Object> generator)
        {
            _generator = generator;
        }

        public Object GetValue(IContainerService container)
        {
            return _generator(container);
        }

        private readonly Func<IContainerService, Object> _generator;
    }
}