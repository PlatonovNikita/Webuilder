/* An abstract class that implements the IComponentContainer interface
 */

namespace Webuilder.Component
{
    internal abstract class ComponentConteiner : IComponentContainer<IComponent>
    {
        public virtual IComponent Parent => throw new NotImplementedException();

        public virtual IComponent[] Components => throw new NotImplementedException();

        public virtual void AddChild(IComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual IComponent GetComponent(string name)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveChild(IComponent component)
        {
            throw new NotImplementedException();
        }
    }
}
