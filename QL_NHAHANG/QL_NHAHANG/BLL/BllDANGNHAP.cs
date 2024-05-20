using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHAHANG.BLL
{
    class BllDANGNHAP
    {
        DAL.DalDANGNHAP dal_DN;
        frm_DangNhap DN;
        PictureBox pictureBox1;
        public BllDANGNHAP(frm_DangNhap fDN)
        {
            dal_DN = new DAL.DalDANGNHAP();
            DN = fDN;
            pictureBox1 =new PictureBox();
            Captcha();
        }
        public void BllLogin()
        {
            string tenDangNhap = DN.txt_DangNhap.Text;
            string matKhau = DN.txt_MatKhau.Text;
            int ketqua = dal_DN.DalLogin(tenDangNhap, matKhau);
            if (ketqua >= 1)
            {
                if (DN.txt_Captcha.Text == captcha.ToString())
                {
                    frm_TrangChu SV = new frm_TrangChu();
                    SV.Show();
                }
                else MessageBox.Show("Nhập sai Captcha");
            }
            else MessageBox.Show("Nhập sai tên DN hoặc MK");
            Captcha();
        }
        string captcha = "";
        string value;
        private void Captcha()
        {
            Random r1 = new Random();
            captcha = RandomString(5); 
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Lucida Handwriting", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha.ToString(), font, Brushes.Green, new Point(0, 5));
            int count = 0;
            while (count < 20)
            {
                graphics.DrawLine(new Pen(Color.Red), r1.Next(0, image.Width), r1.Next(0, image.Height), r1.Next(0, image.Width), r1.Next(0, image.Height));
                count++;
            }
            DN.pictureBox1.Image = image;

        }
        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
    }
}
