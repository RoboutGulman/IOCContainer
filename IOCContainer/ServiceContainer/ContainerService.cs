using IOCContainer.ContainerEntry;

namespace IOCContainer.ServiceContainer
{
    internal class ContainerService: IContainerService
    {
        public ContainerService()
        {
            _containerEntries = new Dictionary<Object, IContainerEntry>();
        }

        public void Bind(Type key, IContainerEntry entry) 
        {
            _containerEntries.Add(key, entry);
        }

        public void Bind<T>(IContainerEntry entry)
        {
            Bind(typeof(T), entry);
        }

        public Object Resolve(Type key)
        {
            if (_containerEntries.TryGetValue(key, out IContainerEntry? entry))
                return entry.GetValue(this);

            throw new Exception("service not found");
        }
        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private readonly IDictionary<Object, IContainerEntry> _containerEntries;
    }
}
