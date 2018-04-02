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
    class FillHinhTron : HinhChuNhat
    {

        #region Constructor
        public FillHinhTron()
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

        public FillHinhTron(Pen curPen)
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
        public FillHinhTron(Pen curPen, Point diembatdau, Point diemketthuc, Point diemmousedown,
                 GraphicsPath graphicspath, Region khuvuc, int vitrichuotsovoihinhve,
                    bool dichuyen, int loaihinh)
            : base(curPen, diembatdau, diemketthuc, diemmousedown,  graphicspath, khuvuc, vitrichuotsovoihinhve, dichuyen,  loaihinh)
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
            Brush brush = new SolidBrush(Color.FromArgb(255, pen.Color));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillEllipse(brush, VeHCN(diemBatDau, new Point(diemKetThuc.X, diemBatDau.Y + diemKetThuc.X - diemBatDau.X)));
            brush.Dispose();
  
        }

        #endregion
        
        #region Tuần tự hóa 
        public FillHinhTron(SerializationInfo info, StreamingContext ctxt)
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
