/* An abstract class that have base builder functionality
 * 
 * "ComponentBuilder<T> where T : ComponentBuilder<T>" 
 *      - provide returned T, where T is child class, 
 *      builder child class of component
 */

using Webuilder.Helpers;

namespace Webuilder.Component
{
    public abstract class ComponentBuilder<T> where T : ComponentBuilder<T>
    {
        private protected string? _name;

        private protected string? _clas;

        private protected string? _localId;

        private protected int _width = 0;

        private protected int _grid = 0;

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

        public virtual T WithLocalId(string localId)
        {
            if (string.IsNullOrWhiteSpace(localId))
            {
                throw new ArgumentNullException(nameof(localId));
            }
            _localId = localId;
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

        private protected virtual void CheckDefauldComponentFields()
        {
            ComponentErrorHelper.CheckForNull(_name, nameof(_name));
            ComponentErrorHelper.CheckForNull(_localId, nameof(_localId));
            ComponentErrorHelper.CheckForNull(_clas, nameof(_clas));
            ComponentErrorHelper.CheckGrid(_grid);
            ComponentErrorHelper.CheckWidth(_width, _grid);
        }
    }
}
