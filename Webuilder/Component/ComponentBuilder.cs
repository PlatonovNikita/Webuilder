/* An abstract class that have base builder functionality
 * 
 * "ComponentBuilder<T> where T : ComponentBuilder<T>" 
 *      - provide returned T, where T is child class, 
 *      builder child class of component
 */

using Webuilder.Helpers;

namespace Webuilder.Component
{
    internal abstract class ComponentBuilder<T> where T : ComponentBuilder<T>
    {
        private string? _name;

        private string? _clas;

        private string? _id;

        private int _width = 0;

        private int _grid = 0;

        public virtual T WithName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name");
            }
            _name = name;
            return this as T;
        }

        public virtual T WithClass(string clas)
        {
            if (string.IsNullOrWhiteSpace(clas))
            {
                throw new ArgumentNullException(nameof(clas));
            }
            _clas = clas;
            return this as T;
        }

        public virtual T WithId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(nameof(id));
            }
            _id = id;
            return this as T;
        }

        public virtual T WithGrid(int grid)
        {
            ComponentErrorHelper.CheckGrid(grid);
            _grid = grid;
            return this as T;
        }

        public virtual T WithWidth(int width)
        {
            ComponentErrorHelper.CheckWidth(width, _grid);
            _width = width;
            return this as T;
        }
    }
}
