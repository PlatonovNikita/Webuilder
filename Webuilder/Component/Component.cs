/* An abstract class that implements the part of IComponent interface
 * and pass implementing Rander method to child class
 */

namespace Webuilder.Component
{
    public abstract class Component : ComponentConteiner, IComponent
    {
        private protected string _name;

        private protected string _className;

        private protected string _localId;

        private protected int _width;

        private protected int _grid;

        public virtual string Name => _name;

        public virtual string Class => _className;

        public virtual string LocalId => _localId;

        public virtual int Width => _width;

        public virtual int Grid => _grid;

        public abstract string Rander();

        private protected Component(string name, string className, string localId, int width, int grid)
        {
            _name = name;
            _className = className;
            _localId = localId;
            _width = width;
            _grid = grid;
        } 
    }
}
