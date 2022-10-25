using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webuilder.Component.Implementations.SimpleComponent
{
    public class SimpleComponent : Component
    {
        public static SimpleComponentBuilder GetBuilder()
        {
            return new SimpleComponentBuilder();
        }

        internal SimpleComponent(string name, string clas, string id, int width, int grid) 
                          : base(name, clas, id, width, grid)
        {
        }

        public override string Rander()
        {
            throw new NotImplementedException();
        }
    }
}
