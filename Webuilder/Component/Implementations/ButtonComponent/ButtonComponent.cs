using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webuilder.Component.Implementations.ButtonComponent
{
    public class ButtonComponent : Component
    {
        private string _text;

        private string _action;

        private string[] _requiredParameters;

        public string Text { get => _text;}

        public string Action { get => _action;}

        public string[]? RequiredParameters { get => _requiredParameters;}

        public static ButtonComponentBuilder GetBuilder()
        {
            return new ButtonComponentBuilder();
        }

        internal ButtonComponent(string text, string action, string[] requiredParameters,
                               string name, string clas, string id, int width, int grid) 
                        : base(name, clas, id, width, grid)
        {
            _text = text;
            _action = action;
            _requiredParameters = requiredParameters;
        }

        public override string Rander()
        {
            throw new NotImplementedException();
        }
    }
}
