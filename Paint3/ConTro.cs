using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class ConTro:HinhChuNhat
    {

        #region Constuctor 
        public ConTro()
            : base()
        {
            diemBatDau.X = 0; diemBatDau.Y = 0;
            diemKetThuc.X = 0; diemKetThuc.Y = 1;
            Pen pen = new Pen(Color.Black, 1);
            graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(0, 0, 0, 1));
            graphicsPath.Widen(pen);
            khuVuc = new Region(new Rectangle(0, 0, 0, 1));
            khuVuc.Union(graphicsPath);
            loaiHinh = 0;
        }
        public ConTro(Pen curPen)
            : base(curPen)
        {
            diemBatDau.X = 0; diemBatDau.Y = 0;
            diemKetThuc.X = 0; diemKetThuc.Y = 1;
            pen = new Pen(curPen.Color, curPen.Width);
            pen.DashStyle = curPen.DashStyle;
            graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(0, 0, 0, 1));
            graphicsPath.Widen(pen);
            khuVuc = new Region(new Rectangle(0, 0, 0, 1));
            khuVuc.Union(graphicsPath);
            loaiHinh = 0;
        }
#endregion

        #region Methods
        // Vẽ
        public override void Ve(Graphics g)
        {
            Pen drawpen = new Pen(pen.Color, pen.Width);
            drawpen.DashStyle = pen.DashStyle;
            drawpen.DashStyle = DashStyle.DashDot;
            drawpen.DashOffset = 10;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(drawpen, VeHCN(diemBatDau, diemKetThuc));
            drawpen.Dispose();
        }
        public override void Mouse_Up(object sender)
        {
            
        }
#endregion
    }
}
