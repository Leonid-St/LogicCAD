using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using WinFormsApp3.Nodes;

namespace WinFormsApp3
{
    /// <summary>
    /// Конечный нод. 
    /// Считает итоговую надежность системы.
    /// </summary>
    public class FinishNode : Node
    {
        public override Color BorderColor => Color.SkyBlue;

        public FinishNode(Model model) : base(model)
        {
        }

        public override void Paint(Graphics gr)
        {
            if (Linked.Count == 0)
            {
                Tag = "Finish";
            }
            else
            {
                var p = Calc(this);
                Tag = string.Format("P = {0:0.00}", p);
            }

            base.Paint(gr);
        }

        private static float Calc(Node node)
        {

            //стартовый нод всегда дает 1
            if (node is StartNode) return 1;

            //считаем входящие параллельные
            var p = 1f;
            foreach (var n in node.Linked)
                p *= (1 - Calc(n));
            p = 1 - p;

            //домножаем на свой коэффициент
            if (node.Tag is float)
                p *= (float)node.Tag;

            return p;

            /*
                        if (!(node.Tag is float))
                        {
                            if (node.Linked.Count == 0) return 1;
                            return node.Linked.Min(n => Calc(n));//ищем минимум среди входящих
                        }
                        else
                        {
                            var p = (float)node.Tag;
                            if (node.Linked.Count == 0) return p;
                            return p * node.Linked.Min(n => Calc(n));//ищем минимум среди входящих, умножаем на свою вероятность
                        }*/
        }
    }
}
