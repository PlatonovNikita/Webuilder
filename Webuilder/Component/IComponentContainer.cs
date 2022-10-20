/* An interface describing the basic functionality of a component
 * as a container of components
 */

namespace Webuilder.Component
{
    internal interface IComponentContainer<T> where T : IComponentContainer<T>
    {
        T Parent { get; }

        T[] Components { get; }

        T GetComponent(string name);

        void AddChild(T component);

        void AddCildren(T[] components);

        void RemoveChild(T component);
    }
}
