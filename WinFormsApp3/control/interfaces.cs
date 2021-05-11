using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Data;



namespace WinFormsApp3
{
    /// <summary>
    /// Умеет себя рисовать
    /// </summary>
    public interface IDrawable
    {
        void Paint(Graphics gr);
    }

    /// <summary>
    /// Умеет себя перемещать
    /// </summary>
    public interface IDragable
    {
        bool Hit(Point point);
        void Drag(Point offset);
        IDragable StartDrag(Point p);
        void EndDrag();
    }
}
