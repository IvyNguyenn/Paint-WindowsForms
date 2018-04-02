using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [Serializable()]
    class Ellipse:HinhChuNhat
    {

        #region Constructor 
        public Ellipse()
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
            loaiHinh = 1;
        }

        public Ellipse(Pen curPen)
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
            loaiHinh = 1;
        }
        public Ellipse(Pen curPen , Point diembatdau , Point diemketthuc , Point diemmousedown ,
                GraphicsPath graphicspath , Region khuvuc , int vitrichuotsovoihinhve ,
                bool dichuyen , int loaihinh)
            : base(curPen, diembatdau , diemketthuc , diemmousedown , graphicspath , khuvuc , vitrichuotsovoihinhve , dichuyen , loaihinh)
        {
            pen = new Pen(curPen.Color, curPen.Width);
            pen.DashStyle = curPen.DashStyle;
            diemBatDau = diembatdau;
            diemKetThuc = diemketthuc;
            diemMouseDown = diemmousedown;
            graphicsPath = graphicspath;
            khuVuc = khuvuc;
            viTriChuotSoVoiHinhVe = vitrichuotsovoihinhve;
            diChuyen = dichuyen;
            loaihinh = loaiHinh;
        }
#endregion

        #region Methods
        public override void Ve(Graphics g)
        {
            Pen drawpen = new Pen(pen.Color, pen.Width);
            drawpen.DashStyle = pen.DashStyle;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawEllipse(drawpen, VeHCN(diemBatDau, diemKetThuc));
            drawpen.Dispose();
        }

        #endregion

        #region Tuần tự hóa và giải tuần tự hóa
        public Ellipse(SerializationInfo info, StreamingContext ctxt)
             : base(info, ctxt)
        {
            khuVuc = new Region(VeHCN(diemBatDau, diemKetThuc));
        }
        public new void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
        }
        #endregion
    }
}
