using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webuilder.Helpers;

namespace Webuilder.Component.Implementations.ButtonComponent
{
    public class ButtonComponentBuilder : ComponentBuilder<ButtonComponentBuilder>
    {
        private string? _text;

        private string? _action;

        private string[]? _requiredParameters;

        public ButtonComponentBuilder WithText(string text)
        {
            ComponentErrorHelper.CheckForNull(text, nameof(text));
            _text = text;
            return this;
        }

        public ButtonComponentBuilder WithAction(string action)
        {
            ComponentErrorHelper.CheckForNull(action, nameof(action));
            _action = action;
            return this;
        }

        public ButtonComponentBuilder WithRequiredParameters(string[] requiredParameters)
        {
            ComponentErrorHelper.CheckForNull(requiredParameters, nameof(requiredParameters));
            _requiredParameters = requiredParameters;
            return this;
        }

        public ButtonComponent Build()
        {
            CheckDefauldComponentFields();

            ComponentErrorHelper.CheckForNull(_text, nameof(_text));
            ComponentErrorHelper.CheckForNull(_action, nameof(_action));

            var buttonComponent = new ButtonComponent(_text, _action, _requiredParameters, 
                                                      _name, _clas, _localId, _width, _grid);
            return buttonComponent;
        }
    }
}
