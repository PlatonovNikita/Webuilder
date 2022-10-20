/* An abstract class that implements the part of IComponent interface
 * and pass implementing Rander method to child class
 */

namespace Webuilder.Component
{
    public abstract class Component : ComponentConteiner, IComponent
    {
        private protected string _name;

        private protected string _clas;

        private protected string _id;

        private protected int _width;

        private protected int _grid;

        public virtual string Name => _name;

        public virtual string Class => _clas;

        public virtual string Id => _id;

        public virtual int Width => _width;

        public virtual int Grid => _grid;

        public abstract string Rander();

        private protected Component(string name, string clas, string id, int width, int grid)
        {
            _name = name;
            _clas = clas;
            _id = id;
            _width = width;
            _grid = grid;
        } 
    }
}
