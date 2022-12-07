
namespace SemanticNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBoxCacYeuTo = new System.Windows.Forms.GroupBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtBxKQ = new System.Windows.Forms.TextBox();
            this.btnChay = new System.Windows.Forms.Button();
            this.cbbGiaTriTinh = new System.Windows.Forms.ComboBox();
            this.txtBxDC = new System.Windows.Forms.TextBox();
            this.txtBxDT = new System.Windows.Forms.TextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.groupBoxCanh = new System.Windows.Forms.GroupBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtBxB = new System.Windows.Forms.TextBox();
            this.txtBxC = new System.Windows.Forms.TextBox();
            this.txtBxA = new System.Windows.Forms.TextBox();
            this.groupBoxGoc = new System.Windows.Forms.GroupBox();
            this.txtBxAlpha = new System.Windows.Forms.TextBox();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.txtBxBeta = new System.Windows.Forms.TextBox();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.groupBoxCacBuoc = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.ListBox();
            this.groupBoxCacYeuTo.SuspendLayout();
            this.groupBoxCanh.SuspendLayout();
            this.groupBoxGoc.SuspendLayout();
            this.groupBoxCacBuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(12, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(505, 24);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÀI TOÁN HÌNH TAM GIÁC SỬ DỤNG MẠNG NGỮ NGHĨA";
            // 
            // groupBoxCacYeuTo
            // 
            this.groupBoxCacYeuTo.Controls.Add(this.lblKQ);
            this.groupBoxCacYeuTo.Controls.Add(this.btnLamLai);
            this.groupBoxCacYeuTo.Controls.Add(this.txtBxKQ);
            this.groupBoxCacYeuTo.Controls.Add(this.btnChay);
            this.groupBoxCacYeuTo.Controls.Add(this.cbbGiaTriTinh);
            this.groupBoxCacYeuTo.Controls.Add(this.txtBxDC);
            this.groupBoxCacYeuTo.Controls.Add(this.txtBxDT);
            this.groupBoxCacYeuTo.Controls.Add(this.lblDT);
            this.groupBoxCacYeuTo.Controls.Add(this.lblDC);
            this.groupBoxCacYeuTo.Controls.Add(this.groupBoxCanh);
            this.groupBoxCacYeuTo.Controls.Add(this.groupBoxGoc);
            this.groupBoxCacYeuTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCacYeuTo.Location = new System.Drawing.Point(12, 46);
            this.groupBoxCacYeuTo.Name = "groupBoxCacYeuTo";
            this.groupBoxCacYeuTo.Size = new System.Drawing.Size(505, 181);
            this.groupBoxCacYeuTo.TabIndex = 1;
            this.groupBoxCacYeuTo.TabStop = false;
            this.groupBoxCacYeuTo.Text = "CÁC YẾU TỐ TRONG TAM GIÁC";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(336, 83);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(49, 15);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "Kết quả";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(315, 138);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "LÀM LẠI";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtBxKQ
            // 
            this.txtBxKQ.Location = new System.Drawing.Point(391, 80);
            this.txtBxKQ.Name = "txtBxKQ";
            this.txtBxKQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxKQ.Size = new System.Drawing.Size(65, 21);
            this.txtBxKQ.TabIndex = 0;
            // 
            // btnChay
            // 
            this.btnChay.Location = new System.Drawing.Point(424, 138);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(75, 23);
            this.btnChay.TabIndex = 6;
            this.btnChay.Text = "CHẠY";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // cbbGiaTriTinh
            // 
            this.cbbGiaTriTinh.FormattingEnabled = true;
            this.cbbGiaTriTinh.Items.AddRange(new object[] {
            "Chọn giá trị",
            "Góc Alpha",
            "Góc Beta",
            "Góc Delta",
            "Cạnh a",
            "Cạnh b",
            "Cạnh c",
            "Đường cao",
            "Nửa Chu vi",
            "Diện tích"});
            this.cbbGiaTriTinh.Location = new System.Drawing.Point(335, 45);
            this.cbbGiaTriTinh.Name = "cbbGiaTriTinh";
            this.cbbGiaTriTinh.Size = new System.Drawing.Size(121, 23);
            this.cbbGiaTriTinh.TabIndex = 5;
            this.cbbGiaTriTinh.Text = "Chọn giá trị tính";
            // 
            // txtBxDC
            // 
            this.txtBxDC.Location = new System.Drawing.Point(85, 143);
            this.txtBxDC.Name = "txtBxDC";
            this.txtBxDC.Size = new System.Drawing.Size(60, 21);
            this.txtBxDC.TabIndex = 4;
            // 
            // txtBxDT
            // 
            this.txtBxDT.Location = new System.Drawing.Point(225, 143);
            this.txtBxDT.Name = "txtBxDT";
            this.txtBxDT.Size = new System.Drawing.Size(60, 21);
            this.txtBxDT.TabIndex = 3;
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(168, 146);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(55, 15);
            this.lblDT.TabIndex = 2;
            this.lblDT.Text = "Diện tích";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(12, 146);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(67, 15);
            this.lblDC.TabIndex = 1;
            this.lblDC.Text = "Đường cao";
            // 
            // groupBoxCanh
            // 
            this.groupBoxCanh.Controls.Add(this.lblC);
            this.groupBoxCanh.Controls.Add(this.lblB);
            this.groupBoxCanh.Controls.Add(this.lblA);
            this.groupBoxCanh.Controls.Add(this.txtBxB);
            this.groupBoxCanh.Controls.Add(this.txtBxC);
            this.groupBoxCanh.Controls.Add(this.txtBxA);
            this.groupBoxCanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCanh.Location = new System.Drawing.Point(172, 28);
            this.groupBoxCanh.Name = "groupBoxCanh";
            this.groupBoxCanh.Size = new System.Drawing.Size(122, 105);
            this.groupBoxCanh.TabIndex = 0;
            this.groupBoxCanh.TabStop = false;
            this.groupBoxCanh.Text = "CẠNH";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(6, 79);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(45, 15);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Cạnh c";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(6, 52);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(46, 15);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "Cạnh b";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 25);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(46, 15);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "Cạnh a";
            // 
            // txtBxB
            // 
            this.txtBxB.Location = new System.Drawing.Point(53, 48);
            this.txtBxB.Name = "txtBxB";
            this.txtBxB.Size = new System.Drawing.Size(60, 21);
            this.txtBxB.TabIndex = 2;
            // 
            // txtBxC
            // 
            this.txtBxC.Location = new System.Drawing.Point(53, 75);
            this.txtBxC.Name = "txtBxC";
            this.txtBxC.Size = new System.Drawing.Size(60, 21);
            this.txtBxC.TabIndex = 1;
            // 
            // txtBxA
            // 
            this.txtBxA.Location = new System.Drawing.Point(53, 22);
            this.txtBxA.Name = "txtBxA";
            this.txtBxA.Size = new System.Drawing.Size(60, 21);
            this.txtBxA.TabIndex = 0;
            // 
            // groupBoxGoc
            // 
            this.groupBoxGoc.Controls.Add(this.txtBxAlpha);
            this.groupBoxGoc.Controls.Add(this.txtDelta);
            this.groupBoxGoc.Controls.Add(this.txtBxBeta);
            this.groupBoxGoc.Controls.Add(this.lblDelta);
            this.groupBoxGoc.Controls.Add(this.lblBeta);
            this.groupBoxGoc.Controls.Add(this.lblAlpha);
            this.groupBoxGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGoc.Location = new System.Drawing.Point(6, 28);
            this.groupBoxGoc.Name = "groupBoxGoc";
            this.groupBoxGoc.Size = new System.Drawing.Size(151, 105);
            this.groupBoxGoc.TabIndex = 0;
            this.groupBoxGoc.TabStop = false;
            this.groupBoxGoc.Text = "GÓC";
            // 
            // txtBxAlpha
            // 
            this.txtBxAlpha.Location = new System.Drawing.Point(79, 20);
            this.txtBxAlpha.Name = "txtBxAlpha";
            this.txtBxAlpha.Size = new System.Drawing.Size(60, 21);
            this.txtBxAlpha.TabIndex = 5;
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(79, 74);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.Size = new System.Drawing.Size(60, 21);
            this.txtDelta.TabIndex = 4;
            // 
            // txtBxBeta
            // 
            this.txtBxBeta.Location = new System.Drawing.Point(79, 47);
            this.txtBxBeta.Name = "txtBxBeta";
            this.txtBxBeta.Size = new System.Drawing.Size(60, 21);
            this.txtBxBeta.TabIndex = 3;
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(6, 77);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(61, 15);
            this.lblDelta.TabIndex = 2;
            this.lblDelta.Text = "Góc Delta";
            // 
            // lblBeta
            // 
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(6, 50);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(57, 15);
            this.lblBeta.TabIndex = 1;
            this.lblBeta.Text = "Góc Beta";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(6, 23);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(63, 15);
            this.lblAlpha.TabIndex = 0;
            this.lblAlpha.Text = "Góc Alpha";
            // 
            // groupBoxCacBuoc
            // 
            this.groupBoxCacBuoc.Controls.Add(this.list);
            this.groupBoxCacBuoc.Location = new System.Drawing.Point(12, 233);
            this.groupBoxCacBuoc.Name = "groupBoxCacBuoc";
            this.groupBoxCacBuoc.Size = new System.Drawing.Size(505, 114);
            this.groupBoxCacBuoc.TabIndex = 2;
            this.groupBoxCacBuoc.TabStop = false;
            this.groupBoxCacBuoc.Text = "CÁC BƯỚC TÍNH";
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(6, 19);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(493, 82);
            this.list.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.groupBoxCacBuoc);
            this.Controls.Add(this.groupBoxCacYeuTo);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form1";
            this.Text = "BÀI TOÁN HÌNH TAM GIÁC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCacYeuTo.ResumeLayout(false);
            this.groupBoxCacYeuTo.PerformLayout();
            this.groupBoxCanh.ResumeLayout(false);
            this.groupBoxCanh.PerformLayout();
            this.groupBoxGoc.ResumeLayout(false);
            this.groupBoxGoc.PerformLayout();
            this.groupBoxCacBuoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBoxCacYeuTo;
        private System.Windows.Forms.GroupBox groupBoxCanh;
        private System.Windows.Forms.GroupBox groupBoxGoc;
        private System.Windows.Forms.TextBox txtBxAlpha;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.TextBox txtBxBeta;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.ComboBox cbbGiaTriTinh;
        private System.Windows.Forms.TextBox txtBxDC;
        private System.Windows.Forms.TextBox txtBxDT;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtBxB;
        private System.Windows.Forms.TextBox txtBxC;
        private System.Windows.Forms.TextBox txtBxA;
        private System.Windows.Forms.GroupBox groupBoxCacBuoc;
        private System.Windows.Forms.TextBox txtBxKQ;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label lblKQ;
    }
}

