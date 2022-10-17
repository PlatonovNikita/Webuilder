/* An abstract class that implements the part of IComponent interface
 * and pass implementing Rander method to child class
 */

namespace Webuilder.Component
{
    internal abstract class Component : ComponentConteiner, IComponent
    {
        private string _name;

        private string _clas;

        private string _id;

        private int _width;

        private int _grid;

        public virtual string Name => _name;

        public virtual string Class => _clas;

        public virtual string Id => _id;

        public virtual int Width => _width;

        public virtual int Grid => _grid;

        public abstract string Rander();

        protected Component(string name, string clas, string id, int width, int grid)
        {
            _name = name;
            _clas = clas;
            _id = id;
            _width = width;
            _grid = grid;
        } 
    }
}
