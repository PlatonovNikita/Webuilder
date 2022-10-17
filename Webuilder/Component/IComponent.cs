/* An interface describing the basic functionality of a component
 */

namespace Webuilder.Component
{
    internal interface IComponent : IComponentContainer<IComponent>
    {
        string Name { get; }

        string Class { get; }

        string Id { get; }

        int Width { get; }

        int Grid { get; }

        string Rander();

        //IStyle[] Styles { get; }
        
        //IView View { get; }
    }
}
