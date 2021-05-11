using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp3
{
    static class Helper
    {
        public static Point Add(this Point point, Point other)
    {
        return new Point(point.X + other.X, point.Y + other.Y);
    }

    public static Point Sub(this Point point, Point other)
    {
        return new Point(point.X - other.X, point.Y - other.Y);
    }

    public static Font Font = new Font(FontFamily.GenericSansSerif, 14);

    /// <summary>
    /// Прямоугольник с закругленными углами
    /// </summary>
    public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
    {
        var gp = new GraphicsPath();

        gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
        gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
        gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
        gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
        gp.CloseFigure();

        return gp;
    }

    static Pen pen = new Pen(Color.Bisque);
    static SolidBrush brush = new SolidBrush(Color.Bisque);

    public static Pen Pen(this Color color, float width = 1f)
    {
        pen.Color = color;
        pen.Width = width;
        return pen;
    }

    public static SolidBrush Brush(this Color color)
    {
        brush.Color = color;
        return brush;
    }

    public static void DrawHalo(this GraphicsPath path, Graphics gr,
        Color color, Pen pen, float lineWidth = 1f, int size = 3, int step = 3,
        int opaque = 128, PointF? offset = null)
    {
        if (size <= 0) return;

        var state = gr.Save();

        if (offset != null)
            gr.TranslateTransform(offset.Value.X, offset.Value.Y);

        for (int i = size; i > 0; i--)
        {
            pen.Color = color.Opaque(1f * opaque / size);
            pen.Width = lineWidth + i * step;
            gr.DrawPath(pen, path);
        }

        gr.Restore(state);
    }

    public static Color Opaque(this Color color, float opaque)
    {
        return Color.FromArgb((opaque * color.A / 255).To255(), color);
    }

    public static byte To255(this float v)
    {
        if (v > 255) return 255;
        if (v < 0) return 0;
        return (byte)v;
    }

    public static void DrawLink(this Graphics gr, Point p1, Point p2)
    {
        using (var pen = new Pen(Color.Lime, 2))
            gr.DrawBezier(pen, p1, new Point(p1.X + 50, p1.Y), new Point(p2.X - 50, p2.Y), p2);
    }
}
}
