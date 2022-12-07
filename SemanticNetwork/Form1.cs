using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemanticNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbGiaTriTinh.SelectedItem = cbbGiaTriTinh.Items[0];
            arr();
        }

        #region KHAI BÁO BIẾN

        public string[] YEUTO = { "Góc Alpha", "Góc Beta", "Góc Delta", "Cạnh a", "Cạnh b", "Cạnh c", "Chiều Cao (h)", "Nửa Chu Vi", "Bán Kính (r)", "Diện Tích (S)" };
        private float congThuc = 12, yeuTo = 10;
        private float[,] a = new float[10, 12];
        private const float goc = 180f;
        private float kq = 0;
        private float[,] arrLuu = new float[10, 12];
        private int stop;
        bool flag;
        //Pen Mypen = new Pen(Color.Green, 4);
        Timer myTime = new Timer();

        #endregion

        #region KHỞI TẠO MẢNG
        private void arr()
        {
            float temp = -1;
            for (int i = 0; i < yeuTo; i++)
                for (int j = 0; j < congThuc; j++)
                {
                    a[i, j] = 0;
                    arrLuu[i, j] = 0;
                }
            
            //Mảng xử lý
            a[0, 0] = a[0, 3] = a[0, 6] = temp;
            a[1, 0] = a[1, 1] = a[1, 2] = a[1, 4] = a[1, 7] = temp;
            a[2, 1] = a[2, 2] = a[2, 5] = a[2, 8] = a[2, 11] = temp;
            a[3, 0] = a[3, 3] = a[3, 4] = a[3, 5] = a[3, 7] = a[3, 8] = a[3, 9] = a[3, 10] = temp;
            a[4, 0] = a[4, 1] = a[4, 3] = a[4, 4] = a[4, 5] = a[4, 6] = a[4, 8] = a[4, 9] = a[4, 10] = a[4, 11] = temp;
            a[5, 1] = a[5, 3] = a[5, 4] = a[5, 5] = a[5, 6] = a[5, 7] = a[5, 9] = a[5, 10] = temp;
            a[6, 6] = a[6, 7] = a[6, 8] = a[6, 10] = temp;
            a[7, 11] = temp;
            a[8, 10] = temp;
            a[9, 9] = temp;
        }
        #endregion

        #region XỬ LÝ

        //Kiểm tra xem giá trị ở combobox đã được tính chưa.
        private bool tinhGiaTri()
        {
            switch (cbbGiaTriTinh.SelectedIndex)
            {
                case 1:
                    if (a[0, 0] == -1)
                        break;
                    return true;

                case 2:
                    if (a[1, 0] == -1)
                        break;
                    return true;
                case 3:
                    if (a[2, 1] == -1)
                        break;
                    return true;
                case 4:
                    if (a[3, 0] == -1)
                        break;
                    return true;
                case 5:
                    if (a[4, 0] == -1)
                        break;
                    return true;
                case 6:
                    if (a[5, 1] == -1)
                        break;
                    return true;
                case 7:
                    if (a[7, 11] == -1)
                        break;
                    return true;
                case 8:
                    if (a[8, 10] == -1)
                        break;
                    return true;
                case 9:
                    if (a[6, 6] == -1)
                        break;
                    return true;
                case 10:
                    if (a[9, 9] == -1)
                        break;
                    return true;
            }
            return false;
        }
        //Hiển thị lên Textbox kết quả.
        public void hienThiKetQua()
        {
            switch (cbbGiaTriTinh.SelectedIndex)
            {
                case 1:
                    kq = (float)((a[0, 0] * goc) / Math.PI);
                    txtBxKQ.Text = kq.ToString();
                    break;

                case 2:
                    kq = (float)((a[1, 0] * goc) / Math.PI);
                    txtBxKQ.Text = kq.ToString();
                    break;

                case 3:
                    kq = (float)((a[2, 1] * goc) / Math.PI);
                    txtBxKQ.Text = kq.ToString();
                    break;

                case 4:
                    txtBxKQ.Text = a[3, 0].ToString();
                    break;

                case 5:
                    txtBxKQ.Text = a[4, 0].ToString();
                    break;

                case 6:
                    txtBxKQ.Text = a[5, 1].ToString();
                    break;

                case 7:
                    txtBxKQ.Text = a[7, 11].ToString();
                    break;

                case 8:
                    txtBxKQ.Text = a[8, 10].ToString();
                    break;

                case 9:
                    kq = a[6, 6];
                    txtBxKQ.Text = kq.ToString();
                    break;
                case 10:
                    txtBxKQ.Text = a[9, 9].ToString();
                    break;
            }
        }

        //Kiểm tra xem yếu tố nào có thể tính.
        private int layYeuTo(int congThuc1)
        {
            int dem = 0, gt = -1;
            for (int i = 0; i < yeuTo; i++)
                if (a[i, congThuc1] == -1)
                {
                    dem++;
                    gt = i;
                }
            if (dem == 1)
                return gt;
            return -1;
        }

        // Hàm giải PT bậc 2
        private double giaiPt(double a, double b, double c)
        {
            double nghiem = 0;
            double x1;
            double x2;

            double d = b * b - 4 * a * c;
            if (d == 0)
                nghiem = -b / (2 * a);
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                if (x1 > 0) nghiem = x1;
                else
                    nghiem = x2;
            }
            return nghiem;
        }

        //Kích hoạt cơ chế lan truyền.
        private void coCheLanTruyen(int congThuc1, int yeuTo1)
        {
            float value = -1, lgt = -1;
            double b = 0;
            double c = 0;
            switch (congThuc1)
            {
                case 0:
                    switch (yeuTo1)
                    {
                        case 0:
                            // sinα= a*sinβ /b
                            lgt = (float)((a[3, 0] * Math.Sin(a[1, 0])) / (a[4, 0]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinα= a*sinβ /b => α =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 1:
                            // sinβ = b*sinα /a
                            lgt = (float)((a[4, 0] * Math.Sin(a[0, 0])) / (a[3, 0]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinβ = b*sinα /a => β =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            // a= b*sinα/ sinβ
                            value = (float)((a[4, 0] * Math.Sin(a[0, 0])) / Math.Sin(a[1, 0]));
                            list.Items.Add("a= b*sinα/ sinβ => a =" + value.ToString());
                            break;
                        case 4:
                            // b= a*sinβ /sinα
                            value = (float)((a[3, 0] * Math.Sin(a[1, 0])) / Math.Sin(a[0, 0]));
                            list.Items.Add("b= a*sinβ /sinα => b =" + value.ToString());
                            break;
                    }
                    break;
                case 1:
                    switch (yeuTo1)
                    {
                        case 1:
                            // sinβ= b*sinδ/c
                            lgt = (float)((a[4, 0] * Math.Sin(a[2, 1])) / (a[5, 1]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinβ= b*sinδ/c => β =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 2:
                            // sinδ = c*sinβ /b
                            lgt = (float)((a[5, 1] * Math.Sin(a[1, 1])) / a[4, 1]);
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinδ = c*sinβ /b => δ =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 4:
                            // b=c*sinβ/sinδ
                            value = (float)((a[5, 1] * Math.Sin(a[1, 0])) / Math.Sin(a[2, 1]));
                            list.Items.Add("b=c*sinβ/sinδ => b =" + value.ToString());
                            break;
                        case 5:
                            // c=b*sinδ /sinβ
                            value = (float)((a[4, 0] * Math.Sin(a[2, 1])) / Math.Sin(a[1, 0]));
                            list.Items.Add("c=b*sinδ /sinβ => c =" + value.ToString());
                            break;
                    }
                    break;

                case 2:
                    switch (yeuTo1)
                    {
                        case 0:
                            // α = pi-β-δ
                            value = (float)((Math.PI - a[1, 0] - a[2, 1]));
                            list.Items.Add("α = pi-β-δ => α =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 1:
                            // β = pi-α-δ
                            value = (float)((Math.PI - a[0, 0] - a[2, 1]));
                            list.Items.Add("β = pi-α-δ => β =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 2:
                            // δ=pi-α-β
                            value = (float)((Math.PI - a[0, 0] - a[1, 0]));
                            list.Items.Add("δ = pi-α-β => δ =" + ((value * goc) / Math.PI).ToString());

                            break;
                    }
                    break;
                case 3:
                    switch (yeuTo1)
                    {
                        case 0:
                            // cosα = (b^2+c^2-a^2)/(2bc)
                            lgt = (float)((a[4, 1] * a[4, 1]) + (a[5, 1] * a[5, 1]) - (a[3, 0] * a[3, 0])) / (2f * a[4, 1] * a[5, 1]);
                            value = (float)Math.Acos(lgt);
                            list.Items.Add("cosα = (b^2+c^2-a^2)/(2bc) =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            // a^2 = b^2 + c^2 - 2b.c.cosα
                            lgt = (float)((a[4, 0] * a[4, 0]) + (a[5, 1] * a[5, 1]) - 2f * a[4, 1] * a[5, 1] * Math.Cos(a[0, 0]));
                            value = (float)Math.Sqrt(lgt);
                            list.Items.Add("a^2 = b^2 + c^2 - 2b.c.cosα => a =" + value.ToString());
                            break;
                        case 4:
                            // b^2 = a^2 - c^2 + 2b.c.cosα
                            b = -(2 * a[5, 1] * Math.Cos(a[0, 0]));
                            c = (a[5, 1] * a[5, 1]) - (a[3, 0] * a[3, 0]);
                            value = (float)giaiPt(1, b, c);

                            list.Items.Add("b^2 = a^2 - c^2 + 2b.c.cosα => b= " + value.ToString());
                            break;
                        case 5:
                            // c^2 = a^2 - b^2 + 2b.c.cosα

                            b = -(2 * a[4, 1] * Math.Cos(a[0, 0]));
                            c = (a[4, 1] * a[4, 1]) - (a[3, 0] * a[3, 0]);
                            value = (float)giaiPt(1, b, c);
                            list.Items.Add("c^2 = a^2 - b^2 + 2b.c.cosα => c= " + value.ToString());
                            break;
                    }
                    break;
                case 4:
                    switch (yeuTo1)
                    {
                        case 1:
                            // cosβ = (a^2+c^2-b^2)/(2ac)
                            lgt = (float)((a[3, 0] * a[3, 0]) + (a[5, 1] * a[5, 1]) - (a[4, 1] * a[4, 1])) / (2f * a[3, 0] * a[5, 1]);
                            value = (float)Math.Acos(lgt);
                            list.Items.Add("cosβ = (a^2+c^2-b^2)/(2ac) => β =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            // a^2 = b^2 - c^2 + 2a.c.cosβ
                            b = -(2 * a[5, 1] * Math.Cos(a[1, 0]));
                            c = (a[5, 1] * a[5, 1]) - (a[4, 1] * a[4, 1]);
                            value = (float)giaiPt(1, b, c);

                            list.Items.Add("a^2 = b^2 - c^2 + 2a.c.cosβ => a = " + value.ToString());
                            break;
                        case 4:
                            // b^2 = a^2 + c^2 - 2a.c.cosβ
                            lgt = (float)((a[3, 0] * a[3, 0]) + (a[5, 1] * a[5, 1]) + 2f * a[3, 0] * a[5, 1] * Math.Cos(a[1, 0]));
                            value = (float)Math.Sqrt(lgt);
                            list.Items.Add("b^2 = a^2 + c^2 - 2a.c.cosβ => b =" + value.ToString());
                            break;
                        case 5:
                            // c^2 = b^2 - a^2 + 2a.c.cosβ
                            b = -(2 * a[3, 0] * Math.Cos(a[1, 0]));
                            c = (a[3, 0] * a[3, 0]) - (a[4, 1] * a[4, 1]);
                            value = (float)giaiPt(1, b, c);

                            list.Items.Add(" c^2 = b^2 - a^2 + 2a.c.cosβ => c = " + value.ToString());
                            break;
                    }
                    break;
                case 5:
                    switch (yeuTo1)
                    {
                        case 2:
                            // cosδ = (a^2 + b^2 -c^2)/2ab
                            lgt = (float)((a[3, 0] * a[3, 0]) + (a[4, 1] * a[4, 1]) - (a[5, 1] * a[5, 1])) / (2f * a[3, 0] * a[4, 1]);
                            value = (float)Math.Acos(lgt);
                            list.Items.Add("cosδ = (a^2 + b^2 -c^2)/2ab => δ =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            // a^2 = c^2 - b^2 + 2a.b.cosδ
                            b = -(2 * a[4, 1] * a[3, 0] * Math.Cos(a[2, 1]));
                            c = (a[4, 1] * a[4, 1]) - (a[5, 1] * a[5, 1]);
                            value = (float)giaiPt(1, b, c);

                            list.Items.Add("a^2 = c^2 - b^2 + 2a.b.cosδ => a = " + value.ToString());
                            break;
                        case 4:
                            // b^2 = c^2 - a^2 + 2a.b.cosδ
                            b = -(2 * a[4, 1] * a[3, 0] * Math.Cos(a[2, 1]));
                            c = (a[3, 0] * a[3, 0]) - (a[5, 1] * a[5, 1]);
                            value = (float)giaiPt(1, b, c);

                            list.Items.Add("b^2 = a^2 + c^2 - 2a.c.cosβ => b =" + value.ToString());
                            break;
                        case 5:
                            // c^2 = a^2 + b^2 - 2a.b.cosδ
                            lgt = (float)((a[3, 0] * a[3, 0]) + (a[4, 1] * a[4, 1]) - 2f * a[3, 0] * a[4, 1] * Math.Cos(a[2, 1]));
                            value = (float)Math.Sqrt(lgt);
                            list.Items.Add("c^2 = a^2 + b^2 - 2a.b.cosδ => c =" + value.ToString());
                            break;
                    }
                    break;
                case 6:
                    switch (yeuTo1)
                    {
                        case 0:
                            //sinα = 2S/bc
                            lgt = (float)((2 * a[6, 6]) / (a[4, 1] * a[5, 1]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinα = 2S/bc => α =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 4:
                            //b = 2S/(c.sinα)
                            value = (float)((2 * a[6, 6]) / (a[5, 1] * Math.Sin(a[0, 0])));
                            list.Items.Add("b = 2S/(c.sinα) => b =" + value.ToString());
                            break;
                        case 5:
                            // c= 2S/(b.sinα)
                            value = (float)((2 * a[6, 6]) / (a[4, 1] * Math.Sin(a[0, 0])));
                            list.Items.Add("c= 2S/(b.sinα)=> c =" + value.ToString());
                            break;
                        case 6:
                            //S = b.c.sinα /2
                            value = (float)(a[4, 1] * a[5, 1] * Math.Sin(a[0, 0]) / 2);
                            list.Items.Add("S = b.c.sinα /2 => S =" + value.ToString());
                            break;
                    }
                    break;
                case 7:
                    switch (yeuTo1)
                    {
                        case 1:
                            //sinβ = 2S/ac
                            lgt = (float)((2 * a[6, 6]) / (a[3, 0] * a[5, 1]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinβ = 2S/ac =>β =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            //a = 2S/(c.sinβ)
                            value = (float)((2 * a[6, 7]) / (a[5, 1] * Math.Sin(a[1, 0])));
                            list.Items.Add("a = 2S/(c.sinβ) => β =" + value.ToString());
                            break;
                        case 5:
                            // c= 2S/(a.sinβ)
                            value = (float)((2 * a[6, 7]) / (a[3, 0] * Math.Sin(a[1, 0])));
                            list.Items.Add("c= 2S/(a.sinβ)=> c =" + value.ToString());
                            break;
                        case 6:
                            //S = a.c.sinβ /2
                            value = (float)(a[3, 0] * a[5, 1] * Math.Sin(a[1, 0]) / 2);
                            list.Items.Add("S = a.c.sinβ /2 => S=" + value.ToString());
                            break;
                    }
                    break;
                case 8:
                    switch (yeuTo1)
                    {
                        case 2:
                            //sinδ = 2S/ab
                            lgt = (float)((2 * a[6, 8]) / (a[3, 0] * a[4, 1]));
                            value = (float)Math.Asin(lgt);
                            list.Items.Add("sinδ = 2S/ab => δ =" + ((value * goc) / Math.PI).ToString());
                            break;
                        case 3:
                            //a = 2S/(b.sinδ)
                            value = (float)((2 * a[6, 8]) / (a[4, 1] * Math.Sin(a[2, 1])));
                            list.Items.Add("a = 2S/(b.sinδ) =>a =" + value.ToString());
                            break;
                        case 4:
                            // b= 2S/(b.sinδ)
                            value = (float)((2 * a[6, 8]) / (a[4, 1] * Math.Sin(a[2, 1])));
                            list.Items.Add("b= 2S/(b.sinδ) => b =" + value.ToString());
                            break;
                        case 6:
                            //S = a.b.sinδ /2
                            value = (float)(a[3, 0] * a[5, 1] * Math.Sin(a[2, 1]) / 2);
                            list.Items.Add("S = a.b.sinδ /2 => S =" + value.ToString());
                            break;
                    }
                    break;
                case 9:
                    switch (yeuTo1)
                    {

                        case 3:
                            // a = 2p - b - c
                            value = (float)(2f * a[6, 2] - a[4, 0] - a[5, 1]);
                            list.Items.Add("a = 2p - b - c => a =" + value.ToString());
                            break;
                        case 4:
                            //b = 2p - a - c
                            value = (float)(2f * a[6, 2] - a[3, 0] - a[5, 1]);
                            list.Items.Add("b = 2p - a - c => b =" + value.ToString());
                            break;
                        case 5:
                            // c = 2p - a - b
                            value = (float)(2f * a[6, 2] - a[3, 0] - a[4, 0]);
                            list.Items.Add("c = 2p - a - b => c =" + value.ToString());
                            break;
                        case 9:
                            //p = (a-b-c)/2
                            value = (float)((a[3, 0] + a[4, 0] + a[5, 1]) / 2f);
                            list.Items.Add("p = (a-b-c)/2=> p =" + value.ToString());
                            break;
                    }
                    break;
                case 10:
                    switch (yeuTo1)
                    {

                        case 3:
                            // a = 4.R.S/(b.c)
                            value = (float)((4f * a[8, 10] * a[6, 8]) / (a[4, 1] * a[5, 1]));
                            list.Items.Add("a = 4.R.S/(b.c) => a =" + value.ToString());
                            break;
                        case 4:
                            // b = 4.R.S/(a.c)
                            value = (float)((4f * a[8, 10] * a[6, 8]) / (a[3, 0] * a[5, 1]));
                            list.Items.Add("b = 4.R.S/(a.c) => b =" + value.ToString());
                            break;
                        case 5:
                            // c = 4.R.S/(a.b)
                            value = (float)((4f * a[8, 10] * a[6, 8]) / (a[3, 0] * a[4, 1]));
                            list.Items.Add(" c = 4.R.S/(a.b) => c =" + value.ToString());
                            break;
                        case 6:
                            // S = (a.b.c)/4R
                            value = (float)((a[3, 0] * a[4, 1]) * a[5, 1] / (4f * a[8, 10]));
                            list.Items.Add(" S = (a.b.c)/4R => S =" + value.ToString());
                            break;
                        case 8:
                            //R = (a.b.c)/4S
                            value = (float)((a[3, 0] * a[4, 1]) * a[5, 1] / (4f * a[6, 8]));
                            list.Items.Add("R = (a.b.c)/4S => R =" + value.ToString());
                            break;
                    }
                    break;
                case 11:
                    switch (yeuTo1)
                    {
                        case 7:
                            //ha = b.sinδ
                            value = (float)((a[4, 1] * Math.Sin(a[2, 1])));
                            list.Items.Add("ha = b.sinδ => ha =" + value.ToString());
                            break;
                    }
                    break;
            }
            if (value <= 0)
            {
                MessageBox.Show("Các yếu tố nhập vào không hợp lệ!!. Vui lòng kiểm tra lại.", "Báo Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stop = 1;
            }
            else
            {
                for (int i = 0; i < congThuc; i++)
                    if (a[yeuTo1, i] == -1)
                    {
                        a[yeuTo1, i] = value;
                        arrLuu[yeuTo1, i] = 1;
                    }
            }
        }

        //Xử lý giá trị truyền vào từ textbox
        private void layGiaTri()
        {
            arr();
            if (!string.IsNullOrEmpty(txtBxAlpha.Text))
            {
                float num = ((float)Math.PI * float.Parse(txtBxAlpha.Text)) / goc;
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[0, i] == -1f && this.a[0, i] != 0)
                    {
                        this.a[0, i] = num;
                        this.arrLuu[0, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxBeta.Text))
            {
                float num1 = ((float)Math.PI * float.Parse(txtBxBeta.Text)) / goc;
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[1, i] == -1f && this.a[1, i] != 0)
                    {
                        this.a[1, i] = num1;
                        this.arrLuu[1, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtDelta.Text))
            {
                float num2 = ((float)Math.PI * float.Parse(txtDelta.Text)) / goc;
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[2, i] == -1f && this.a[2, i] != 0)
                    {
                        this.a[2, i] = num2;
                        this.arrLuu[2, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxA.Text))
            {
                float num3 = float.Parse(txtBxA.Text);
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[3, i] == -1f && this.a[3, i] != 0)
                    {
                        this.a[3, i] = num3;
                        this.arrLuu[3, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxB.Text))
            {
                float num4 = float.Parse(txtBxB.Text);
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[4, i] == -1f && this.a[4, i] != 0)
                    {
                        this.a[4, i] = num4;
                        this.arrLuu[4, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxC.Text))
            {
                float num5 = float.Parse(txtBxC.Text);
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[5, i] == -1f && this.a[5, i] != 0)
                    {
                        this.a[5, i] = num5;
                        this.arrLuu[5, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxDT.Text))
            {
                float num6 = float.Parse(txtBxDT.Text);
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[7, i] == -1f && this.a[7, i] != 0)
                    {
                        this.a[7, i] = num6;
                        this.arrLuu[7, i] = 1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtBxDC.Text))
            {
                float num7 = float.Parse(txtBxDC.Text);
                for (int i = 0; i < congThuc; i++)
                {
                    if (this.a[8, i] == -1f && this.a[8, i] != 0)
                    {
                        this.a[8, i] = num7;
                        this.arrLuu[8, i] = 1;
                    }
                }
            }
        }

        //Tính toán
        private void xuly()
        {
            flag = true;
            layGiaTri();
            while (flag == true)
            {
                flag = false;
                for (int i = 0; i < congThuc; i++)
                {
                    int layyt = layYeuTo(i);
                    if (layyt != -1)
                    {
                        if (stop == 1)
                            break;
                        coCheLanTruyen(i, layyt);
                        flag = true;
                        if (tinhGiaTri())
                        {
                            hienThiKetQua();
                            myTime.Enabled = true;
                            myTime.Interval = 500;
                            flag = false;
                            break;
                        }
                    }
                }
            }
            if (!tinhGiaTri() && stop == 0)
                MessageBox.Show("- Không đủ yếu tố !.\n- Không thể tính kết quả trên mạng ngữ nghĩa đã xây dựng !!.\n- Vui Lòng Xem Trợ Giúp !!", "Báo Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Xử lý ngoại lệ. Điều kiện của một tam giác.
        private int ngoaiLe()
        {
            int kiemtra = 0;
            if (!string.IsNullOrEmpty(txtBxAlpha.Text) && !string.IsNullOrEmpty(txtBxBeta.Text) && !string.IsNullOrEmpty(txtDelta.Text))
                if (float.Parse((txtBxAlpha.Text)) + float.Parse((txtBxBeta.Text)) + float.Parse((txtDelta.Text)) != 180)
                    kiemtra = 1;

            if (!string.IsNullOrEmpty(txtBxA.Text) && !string.IsNullOrEmpty(txtBxB.Text) && !string.IsNullOrEmpty(txtBxC.Text))
                if ((float.Parse((txtBxA.Text)) + float.Parse((txtBxB.Text)) <= float.Parse((txtBxC.Text))) || (float.Parse((txtBxA.Text)) + float.Parse((txtBxC.Text)) <= float.Parse((txtBxB.Text))) || (float.Parse((txtBxB.Text)) + float.Parse((txtBxC.Text)) <= float.Parse((txtBxA.Text))))
                    kiemtra = 2;
            return kiemtra;
        }

        #endregion

        #region TEXTBOX
        //Chỉ cho phép nhập số vào textbox
        private void chiNhapSo(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && ((int)e.KeyChar != 46))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    int ma = (int)e.KeyChar;
                    if ((ma == 26) || (ma == 24) || (ma == 3) || (ma == 22) || (ma == 1))
                        e.Handled = true;
                }
            }
        }

        private void txtBxAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxBeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxDelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        private void txtBxDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            chiNhapSo(e);
        }

        #endregion

        #region BUTTON

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            cbbGiaTriTinh.SelectedItem = cbbGiaTriTinh.Items[0];
            arr();
            txtBxAlpha.Text = txtBxBeta.Text = txtDelta.Text = string.Empty;
            txtBxA.Text = txtBxB.Text = txtBxC.Text = string.Empty;
            txtBxDC.Text = txtBxDT.Text = txtBxKQ.Text = string.Empty;
            list.Items.Clear();
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            if (cbbGiaTriTinh.SelectedItem == cbbGiaTriTinh.Items[0] || ngoaiLe() == 1 || ngoaiLe() == 2)
            {
                if (cbbGiaTriTinh.SelectedItem == cbbGiaTriTinh.Items[0])
                    MessageBox.Show("Chưa chọn giá trị tính!!", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ngoaiLe() == 1 || ngoaiLe() == 2)
                    MessageBox.Show("- Giá trị nhập vào không thỏa mãn điều kiện của 1 tam giác.\n- Vui lòng nhập lại!.", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else xuly();

        }

        #endregion
    }
}