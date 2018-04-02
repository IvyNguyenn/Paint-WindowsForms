using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Paint3
{
    public partial class Form1 : Form
    {
        #region Properties
        private listHinhVe lHV;          // List đối tượng
        private HinhVe hinhHienTai;       // đối tượng hình hiện tại sẽ vẽ
        private int IDhinhHienTai;       // ID của đối tượng hình hiện tại

        private Pen curPen;
        private Brush curBrush;

        private Bitmap hinhNenDuoi;     //hình nền
        private Bitmap hinhNenTren;

        bool isMoving;
        int lastBtnxID;

        List<Label> listLabel = new List<Label>();
        List<Button> listButton = new List<Button>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            KhoiTao();
        }

        public void KhoiTao()
        {
            lHV = new listHinhVe();
            hinhNenDuoi = new Bitmap(btnFillHinhVuong.Width, btnFillHinhVuong.Height, btnFillHinhVuong.CreateGraphics()); //tạo 1 hình bitmap
            Graphics g = Graphics.FromImage(hinhNenDuoi);   //lấy đối tượng Graphics từ bitmap
            g.Clear(Color.White);                           //xóa trắng bề mặt
            hinhNenTren = new Bitmap(btnFillHinhVuong.Width, btnFillHinhVuong.Height, btnFillHinhVuong.CreateGraphics());
            g = Graphics.FromImage(hinhNenTren);
            g.Clear(Color.White);
            curPen = new Pen(Color.Black, 1);
            curBrush = new SolidBrush(Color.Black);
            lastBtnxID = 0;                  //ID của nút bấm
            isMoving = false;
            IDhinhHienTai = 0;
            lHV.listHinh.Clear();
            btnFillHinhVuong.Refresh();       //vẽ lại pictureBox-làm mới
        }

        #region Xử lí sự kiện chuột trên pictureBox

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            hinhNenDuoi = hinhNenTren.Clone(new Rectangle(0, 0, hinhNenTren.Width, hinhNenTren.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb); //sao chép hình nền
            Graphics g = Graphics.FromImage(hinhNenDuoi);
            if (lHV.listHinh.Count > 0)
                lHV.Ve(g);                  //vẽ các hình có trong listHinh lên hình nền
            e.Graphics.DrawImageUnscaled(hinhNenDuoi, 0, 0);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMoving)
                {
                    //đang di chuyển hình
                }
                else
                {
                    if (hinhHienTai == null || hinhHienTai.KiemTraViTri(e.Location) == -1)
                    {
                        hinhHienTai = LayHinhVeHienTai(IDhinhHienTai);
                    }
                    if (hinhHienTai != null)    //&& hinhHienTai.loaiHinh!=0)
                    {
                        hinhHienTai.Mouse_Down(e);          //gọi sự kiện mouse_down của hình
                        btnFillHinhVuong.Refresh();               //làm mới
                        lHV.listHinh.Insert(lHV.listHinh.Count, hinhHienTai);            //thêm hình mới vào list
                    }
                }
            }
            else
            {
                hinhHienTai = null;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosition.Text = "Mouse location: (" + e.Location.X.ToString() + ", " + e.Location.Y.ToString() + ")";

            if (IDhinhHienTai == -1)  //nút "Vị trí và kích cỡ" đã được bấm
            {

                if (isMoving == false)
                {
                    for (int i = lHV.listHinh.ToArray().Length - 1; i >= 0; i--)        //kiểm tra từng hình xem hình nào bị...
                    {

                        int vt = (lHV.listHinh.ToArray())[i].KiemTraViTri(e.Location);
                        if (vt == 0)        //...chuột di chuyển trên bề mặt    
                        {
                            hinhHienTai = (lHV.listHinh.ToArray())[i];
                            if (e.Button == MouseButtons.Left)      //=> sẽ di chuyển hình này
                            {
                                Cursor = Cursors.Hand;
                                hinhHienTai.diChuyen = true;             //cho phép di chuyển
                                isMoving = true;                        //bật cờ đang di chuyển
                                btnCircle_Click(btnConTro, e);        //mượn nút "Chuột" để di chuyển (bản thân nút "Vị trí và kích cỡ" sẽ không di chuyển hình
                                btnFillHinhVuong.Refresh();
                                lHV.listHinh.RemoveAt(i);                                           //sau khi di chuyển sẽ phát sinh hình mới tại vị trí mới=>xóa hình cũ
                            }
                            else // chuột đi qua mà không bấm
                            {
                                isMoving = false;
                                hinhHienTai.diChuyen = false;
                            }
                            Cursor = Cursors.Hand;
                            btnFillHinhVuong.Refresh();
                            break;
                        }
                        else if (vt > 0) //...chuột chỉ đúng điểm điều khiển (1 trong 8 chấm vuông nhỏ làm khung)   => sẽ thay đổi kích thước hình này
                        {
                            hinhHienTai = (lHV.listHinh.ToArray())[i];
                            if (e.Button == MouseButtons.Left)
                            {
                                hinhHienTai.diChuyen = false;               //không cho phép di chuyển
                                isMoving = true;
                                btnCircle_Click(btnConTro, e);
                                btnFillHinhVuong.Refresh();
                                lHV.listHinh.RemoveAt(i);
                            }
                            else
                            {
                                isMoving = false;
                            }

                            Cursor = Cursors.Cross;
                            btnFillHinhVuong.Refresh();
                            break;
                        }

                        else //tìm trong danh sách không có hình nào bị chuột đi qua
                        {
                            Cursor = Cursors.Default;
                        }
                    }
                }
            }
            else  //không phải nút "Vị trí và kích cỡ" => là nút vẽ hình hoặc nút "Chuột"
            {
                if (hinhHienTai != null)
                {

                    if (hinhHienTai.KiemTraViTri(e.Location) > 0)   //nếu chuột chỉ đúng 1 trong 8 chấm vuông nhỏ => đổi chuột thành hình dấu +
                        Cursor = Cursors.Cross;

                    else if (hinhHienTai.KiemTraViTri(e.Location) == 0)     //tương tự với lúc chuột nằm trong hình => chuột hình bàn tay
                        Cursor = Cursors.Hand;
                    else
                        Cursor = Cursors.Default;       //còn lại thì mặc định
                }

                if (e.Button == MouseButtons.Left)
                {

                    if (hinhHienTai != null)
                    {
                        hinhHienTai.Mouse_Move(e);
                        btnFillHinhVuong.Refresh();
                    }
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (hinhHienTai != null && hinhHienTai.loaiHinh == 0 && isMoving == false)
            {
                lHV.XoaHinhCuoi();
                btnFillHinhVuong.Refresh();

                hinhHienTai = null;
            }
            if (hinhHienTai != null && isMoving == false)
            {
                lHV.listHinh.Insert(lHV.listHinh.Count, hinhHienTai); //thêm hình mới vào list
                hinhHienTai.Mouse_Up(sender);
            }
            if (isMoving)
            {
                hinhHienTai.Mouse_Up(sender);
                btnFillHinhVuong.Refresh();
                btnCircle_Click(btnSizeMove, e);
                isMoving = false;
            }
        }


        #endregion

        #region function
        private void Form1_Resize(object sender, EventArgs e)       //sự kiện thay đổi kích thước của form=>hình nền và pictureBox cũng thay đổi theo
        {
            hinhNenDuoi = new Bitmap(btnFillHinhVuong.Width, btnFillHinhVuong.Height, btnFillHinhVuong.CreateGraphics());
            Graphics g = Graphics.FromImage(hinhNenDuoi);
            g.Clear(Color.White);
            hinhNenTren = new Bitmap(btnFillHinhVuong.Width, btnFillHinhVuong.Height, btnFillHinhVuong.CreateGraphics());
            g = Graphics.FromImage(hinhNenTren);
            g.Clear(Color.White);
        }

        HinhVe LayHinhVeHienTai(int IDHinhAnhHienTai)
        {

            switch (IDHinhAnhHienTai)
            {
                case -1: return null;
                case 0: return new ConTro();
                case 1: return new Ellipse(curPen);
                case 2: return new HinhChuNhat(curPen);
                case 3: return new DuongThang(curPen);
                case 4: return new HinhTron(curPen);
                case 5: return new HinhVuong(curPen);
                case 6: return new FillEllipse(curPen);
                case 7: return new FillHinhChuNhat(curPen);
                case 8: return new FillHinhTron(curPen);
                case 9: return new FillHinhVuong(curPen);
                case 10: return new DuongCong(curPen);
                default: return new ConTro(curPen);
            }
        }

        #endregion

        #region Xử lý trên button vẽ hình

        private void btnCircle_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            switch (lastBtnxID)
            {
                case -1:
                    btnSizeMove.Enabled = true;
                    break;
                case 0:
                    btnConTro.Enabled = true;
                    break;
                case 1:
                    btnElip.Enabled = true;
                    break;
                case 2:
                    btnHCN.Enabled = true;
                    break;
                case 3:
                    btnDuongThang.Enabled = true;
                    break;
                case 4:
                    btnHinhTron.Enabled = true;
                    break;
                case 5:
                    btnHinhVuong.Enabled = true;
                    break;
                case 6:
                    btnFillEllipse.Enabled = true;
                    break;
                case 7:
                    btnFillHinhChuNhat.Enabled = true;
                    break;
                case 8:
                    btnFillHinhTron.Enabled = true;
                    break;
                case 9:
                    btnFillSqua.Enabled = true;
                    break;
                case 10:
                    btnBezier.Enabled = true;
                    break;
                default: break;
            }


            IDhinhHienTai = Convert.ToInt16(((Button)sender).Tag);
            lastBtnxID = IDhinhHienTai;
            if (IDhinhHienTai == -1)
            {
                return;
            }
            ((Button)sender).Enabled = false;
        }

        #endregion

        #region control trong C# 

        private void btnMove_Click(object sender, EventArgs e)
        {
            btnCircle_Click(sender, e);
        }

        private void btnColorPen_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(this);
            curPen.Color = colorDialog1.Color;
            lblcurpen.BackColor = curPen.Color;
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            lHV.listHinh.Clear();
            btnFillHinhVuong.Refresh();
        }

        private void btnXoaHinhCuoi_Click(object sender, EventArgs e)
        {
            lHV.XoaHinhCuoi();
            btnFillHinhVuong.Refresh();
            hinhHienTai = null;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            curPen.Width = (float)numericUpDown1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: curPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; break;
                case 1: curPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; break;
                case 2: curPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; break;
                case 3: curPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot; break;
                case 4: curPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot; break;

            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Button btnColor = sender as Button;
            curPen.Color = btnColor.BackColor;
            lblcurpen.BackColor = btnColor.BackColor;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
