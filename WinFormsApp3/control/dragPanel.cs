using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    /// <summary>
    /// Панель, которая умеет отображать IDrawable и перемещать IDragable
    /// </summary>
    public class dragPanel : UserControl
    {
        IEnumerable<object> model;
        Point offset;
        private Point mouseDown;
        IDragable dragged;

        public dragPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                     ControlStyles.Selectable, true);
        }

        public void Build(IEnumerable<object> model)
        {
            this.model = model;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (model == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.TranslateTransform(offset.X, offset.Y);

            //отрисовываем объекты
            foreach (var obj in model.OfType<IDrawable>())
                obj.Paint(e.Graphics);
        }

        Point ToClient(Point p)
        {
            return p.Sub(offset);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = e.Location;
                var p = ToClient(e.Location);
                //ищем объект под мышкой
                var hitted = model.OfType<IDragable>().FirstOrDefault(n => n.Hit(p));
                if (hitted != null)
                    dragged = hitted.StartDrag(p);//начинаем тащить
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var shift = new Point(e.Location.X - mouseDown.X, e.Location.Y - mouseDown.Y);
                mouseDown = e.Location;
                //
                if (dragged != null)
                    dragged.Drag(shift);//двигаем объект
                else
                    offset = new Point(offset.X + shift.X, offset.Y + shift.Y);//сдвигаем канвас

                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (dragged != null)
                dragged.EndDrag();
            dragged = null;
            Invalidate();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.Name = "dragPanel";
            this.Size = new System.Drawing.Size(162, 150);
            this.ResumeLayout(false);

        }
    }
}
