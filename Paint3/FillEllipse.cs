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
    class FillEllipse : HinhChuNhat
    {

        #region Constructor 
        public FillEllipse()
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

        public FillEllipse(Pen curPen)
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
        public FillEllipse(Pen curPen, Point diembatdau, Point diemketthuc, Point diemmousedown,
                GraphicsPath graphicspath, Region khuvuc, int vitrichuotsovoihinhve,
                bool dichuyen, int loaihinh)
            : base(curPen, diembatdau, diemketthuc, diemmousedown, graphicspath, khuvuc, vitrichuotsovoihinhve, dichuyen,loaihinh)
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
            Brush brush = new SolidBrush(pen.Color);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillEllipse (brush, VeHCN(diemBatDau, diemKetThuc));
            brush.Dispose();
        }

        //public override void VeKhung(Graphics g)
        //{

        //    base.VeKhung(g);

        //    Pen p = new Pen(Color.Blue, 1);
        //    p.DashStyle = DashStyle.Dash;
        //    p.DashOffset = 20;
        //    g.SmoothingMode = SmoothingMode.AntiAlias;
        //    g.DrawRectangle(p, VeHCN(diemBatDau, diemKetThuc));
        //    p.Dispose();

        //}

        #endregion

        #region Tuần tự hóa 
        public FillEllipse(SerializationInfo info, StreamingContext ctxt)
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
