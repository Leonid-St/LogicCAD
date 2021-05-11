using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WinFormsApp3.Nodes;
namespace WinFormsApp3
{
    class StartNode: Node 
    {
        public override Color BorderColor
        {
            get
            {
                return Color.Magenta;
            }
        }

        public override bool AcceptPin => false;

        public StartNode(Model model) : base(model)
        {
        }
    }
}
