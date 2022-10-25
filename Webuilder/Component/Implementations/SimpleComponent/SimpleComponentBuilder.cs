using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webuilder.Helpers;

namespace Webuilder.Component.Implementations.SimpleComponent
{
    public class SimpleComponentBuilder : ComponentBuilder<SimpleComponentBuilder>
    {
        private IComponent[]? _components;

        public SimpleComponentBuilder WithComponents(IComponent[] components)
        {
            _components = components;
            return this;
        }

        public SimpleComponent Build()
        {
            CheckDefauldComponentFields();

            var simpleComponent = new SimpleComponent(_name, _clas, _localId, _width, _grid);

            if (_components != null)
            {
                simpleComponent.AddCildren(_components);
            }

            return simpleComponent;
        }
    }
}
