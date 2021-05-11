using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp3.Nodes
{
    /// <summary>
    /// Элемент модели, задающий надежность. 
    /// Может быть связан с другими элемнтами.
    /// </summary>
    public class Node : IDrawable, IDragable
    {
        public GraphicsPath Path { get; set; }
        public Point Location;
        public virtual Color BorderColor => Color.Lime;
        public virtual Color FillColor => Color.FromArgb(30, Color.White);
        public object Tag { get; set; }
        public Model Model { get; set; }
        public virtual bool AcceptPin => true;

        public Pin Pin { get; set; }
        public List<Node> Linked { get; set; } = new List<Node>();

        public Node(Model model)
        {
            this.Model = model;
            Path = Helper.GetRoundedRectangle(new Rectangle(-50, -30, 100, 60), 20);

            Pin = new Pin(this) { RelativeLocation = new Point(50, 0) };
        }

        public virtual void Paint(Graphics gr)
        {
            foreach (var linked in Linked)
                gr.DrawLink(linked.Pin.Location, Location.Sub(new Point(50, 0)));

            var state = gr.Save();
            gr.TranslateTransform(Location.X, Location.Y);
            gr.FillPath(FillColor.Brush(), Path);
            gr.DrawPath(BorderColor.Pen(), Path);
            Path.DrawHalo(gr, BorderColor, BorderColor.Pen());
            var rect = Path.GetBounds();
            rect.Inflate(-5, -5);
            if (Tag != null)
                gr.DrawString(Tag.ToString(), Helper.Font, Brushes.White, rect, new StringFormat {
                    Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center
                });
            gr.Restore(state);

            if (Pin != null)
                Pin.Paint(gr);
        }

        public bool Hit(Point p)
        {
            if (Pin != null && Pin.Hit(p))
                return true;

            return Path.IsVisible(p.Sub(Location));
        }

        public void Drag(Point offset)
        {
            Location = Location.Add(offset);
        }

        public IDragable StartDrag(Point p)
        {
            //если кликнули на пин - тянем пин
            if (Pin != null && Pin.Hit(p))
                return Pin;

            //тянем себя
            return this;
        }

        const float GRID_STEP = 20;

        public void EndDrag()
        {
            //выравниваем по сетке
            Location = new Point((int)(GRID_STEP * Math.Round(Location.X / GRID_STEP)), (int)(GRID_STEP * Math.Round(Location.Y / GRID_STEP)));
        }
    }
}
