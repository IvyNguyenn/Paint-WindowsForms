using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace WindowsFormsApplication1
{
    [Serializable()]    //đánh dấu là đối tượng có thể tuần tự hóa
    class HinhVe : ISerializable
    {
        #region Properties

        public Pen pen;
        public Point diemBatDau;           // Điểm bắt đầu vẽ
        public Point diemKetThuc;             // Điểm kết thúc vẽ
        protected Point diemMouseDown;         // Điểm hiện hành
        protected GraphicsPath graphicsPath;  // Công cụ vẽ
        public Region khuVuc;              // Tạo ra 1 vùng
        protected int viTriChuotSoVoiHinhVe;                 // Vị trí tương đối của 1 điểm và đối tượng
        public bool diChuyen;                  // Di chuyển = true/false
        public int loaiHinh;            //Mã loại của hình vẽ.

#endregion

        #region Constructor 
        public HinhVe()
        {
            pen = new Pen(Color.Black, 1);
        }
        public HinhVe(Pen curPen)
        {
            pen = new Pen(curPen.Color, curPen.Width);
            pen.DashStyle = curPen.DashStyle;
        }
        public HinhVe(Pen curPen, Point diembatdau , Point diemketthuc , Point diemmousedown,
           GraphicsPath graphicspath , Region khuvuc , int vitrichuotsovoihinhve ,
            bool dichuyen , int loaihinh)
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
            loaiHinh = loaihinh;
        }

#endregion
 
        #region Methods
        // hoán đổi điểm bắt đầu và kết thúc
        public virtual void ThayDoi()
        {
            if (diemBatDau.X > diemKetThuc.X)
            {
                int tam = diemKetThuc.X;
                diemKetThuc.X = diemBatDau.X;
                diemBatDau.X = tam;
            }
            if (diemBatDau.Y > diemKetThuc.Y)
            {
                int tam = diemKetThuc.Y;
                diemKetThuc.Y = diemBatDau.Y;
                diemBatDau.Y = tam;
            }
        }

        // Vẽ
        public virtual void Ve(Graphics g)
        {
        }
      
        protected virtual bool KiemTraThuoc(Point point)
        {
            if (khuVuc.IsVisible(point) == true)
                return true;
            return false;
        }

        // Kiểm tra vị trí tương đối của 1 điểm và 1 đối tượng
        // - 1 : Nằm ngoài đối tượng
        // =0   : Trong đối tượng
        // >= 1 : Điểm điều khiển 
        public virtual int KiemTraViTri(Point point)
        {
            if (KiemTraThuoc(point) == true)    // điểm đó thuộc khu vực bên trong hình bao quanh
                return 0;
            return -1;  //điểm và hình tách biệt nhau
        }

        // Xác định lại điểm Start và End khi Click vào 1 điểm điều khiển
        protected virtual void ThayDoiDiem(int viTriDiemDieuKhien)
        {
        }

        // Di chuyển đối tượng khi move = true
        public virtual void DiChuyen(int deltaX, int deltaY)
        {
            diemBatDau.X += deltaX;
            diemBatDau.Y += deltaY;
            diemKetThuc.X += deltaX;
            diemKetThuc.Y += deltaY;

        }

        // Sự kiện chuột
        public virtual void Mouse_Down(MouseEventArgs e)
        {
        }
        public virtual void Mouse_Move(MouseEventArgs e)
        {
            
        }
        public virtual void Mouse_Up(Object sender)
        {

        }

        #endregion

        #region Tuần tự hóa
        public HinhVe(SerializationInfo info, StreamingContext ctxt)    //Khoi tao bang cach giai tuan tu
        {
            diemBatDau = (Point)info.GetValue("diemBatDau", typeof(Point));
            diemKetThuc = (Point)info.GetValue("diemKetThuc", typeof(Point));
            loaiHinh = (int)info.GetValue("loaiHinh", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("diemBatDau", diemBatDau);
            info.AddValue("diemKetThuc", diemKetThuc);
            info.AddValue("loaiHinh", loaiHinh);
        }
        #endregion
    }
}
