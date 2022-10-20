/* An interface describing the basic functionality of a component
 */

namespace Webuilder.Component
{
    internal interface IComponent : IComponentContainer<IComponent>
    {
        //GUID Id { get; }
        
        string Name { get; }

        string Class { get; }

        string LocalId { get; }

        int Width { get; }

        int Grid { get; }

        string Rander();

        //IStyle[] Styles { get; }
        
        //IView View { get; }
    }
}
