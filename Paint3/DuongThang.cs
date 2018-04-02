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
    class DuongThang:Ellipse
    {

        #region Constructor 
        public DuongThang()
            : base()
        {
            diemBatDau.X = 0; diemBatDau.Y = 0;
            diemKetThuc.X = 0; diemKetThuc.Y = 1;
            Pen pen = new Pen(Color.Black, 1);
            graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(diemBatDau, diemKetThuc);
            graphicsPath.Widen(pen);
            khuVuc = new Region(graphicsPath);
            loaiHinh = 4;
        }

        public DuongThang(Pen curPen)
            : base(curPen)
        {
            diemBatDau.X = 0; diemBatDau.Y = 0;
            diemKetThuc.X = 0; diemKetThuc.Y = 1;
            pen = new Pen(curPen.Color, curPen.Width);
            pen.DashStyle = curPen.DashStyle;
            graphicsPath = new GraphicsPath();
            graphicsPath.AddLine(diemBatDau, diemKetThuc);
            graphicsPath.Widen(pen);
            khuVuc = new Region(graphicsPath);
            loaiHinh = 4;
        }

        public DuongThang(Pen curPen, Point diembatdau , Point diemketthuc , Point diemmousedown ,
                GraphicsPath graphicspath , Region khuvuc , int vitrichuotsovoihinhve ,
                bool dichuyen , int loaihinh)
            : base(curPen, diembatdau , diemketthuc , diemmousedown , graphicspath , khuvuc , vitrichuotsovoihinhve , dichuyen, loaihinh)
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
        // Vẽ
        public override void Ve(Graphics g)
        {
            Pen drawpen = new Pen(pen.Color, pen.Width);
            drawpen.DashStyle = pen.DashStyle;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(drawpen, diemBatDau, diemKetThuc);
            drawpen.Dispose();
        }

        protected override void ThayDoiDiem(int viTriDiemDieuKhien)
        {
            if (viTriDiemDieuKhien == 1)
            {
                Point point = diemBatDau;
                diemBatDau = diemKetThuc;
                diemKetThuc = point;
            }
        }

        // Sự kiện chuột
        public override void Mouse_Down(MouseEventArgs e)
        {
            viTriChuotSoVoiHinhVe = KiemTraViTri(e.Location);
            if (viTriChuotSoVoiHinhVe == 0)
            {
                diChuyen = true;
                diemMouseDown = e.Location;
            }
            else
            {
                diemBatDau = e.Location;
                diemKetThuc.X = e.X; diemKetThuc.Y = e.Y - 1;
            }
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            if (diChuyen == true)
            {
                int deltaX = e.X - diemMouseDown.X;
                int deltaY = e.Y - diemMouseDown.Y;
                diemMouseDown = e.Location;
                DiChuyen(deltaX, deltaY);
            }
            else
            {
                diemKetThuc = e.Location;
            }
        }

        public override void Mouse_Up(Object sender)
        {
            graphicsPath.AddLine(diemBatDau, diemKetThuc);
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(diemBatDau.X + 10, diemBatDau.Y), new Point(diemKetThuc.X + 10, diemKetThuc.Y));
            gp.AddLine(new Point(diemBatDau.X - 10, diemBatDau.Y), new Point(diemKetThuc.X - 10, diemKetThuc.Y));
            gp.AddLine(new Point(diemBatDau.X , diemBatDau.Y+10), new Point(diemKetThuc.X , diemKetThuc.Y+10));
            gp.AddLine(new Point(diemBatDau.X, diemBatDau.Y - 10), new Point(diemKetThuc.X, diemKetThuc.Y - 10));
            khuVuc = new Region(gp);
            diChuyen = false;
            viTriChuotSoVoiHinhVe = -1;
        }

        #endregion

        #region Tuần tự hóa 
        public DuongThang(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        {

        }
        public new void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            base.GetObjectData(info, ctxt);
        }
        #endregion

    }
}
