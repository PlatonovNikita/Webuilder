/* An abstract class that implements the IComponentContainer interface
 */

namespace Webuilder.Component
{
    public abstract class ComponentConteiner : IComponentContainer<IComponent>
    {
        private protected IComponent _parent;

        private protected List<IComponent> _components = new List<IComponent>();

        public virtual IComponent Parent => _parent;

        public virtual IComponent[] Components => _components.ToArray();

        public virtual void AddChild(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component));
            }

            _components.Add(component);
        }

        public virtual void AddCildren(IComponent[] components)
        {
            _components.AddRange(components);
        }

        public virtual IComponent GetComponent(string name)
        {
            return _components.First(x => x.Name == name);
        }

        public virtual void RemoveChild(IComponent component)
        {
            _components.Remove(component);
        }
    }
}
