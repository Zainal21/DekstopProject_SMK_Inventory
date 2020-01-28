namespace Zainal_PPL_Inventory
{
    partial class Fmenu
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
            this.components = new System.ComponentModel.Container();
            this.panelkonten = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamalvl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtkembali = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtpinjam = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtuser = new Bunifu.Framework.UI.BunifuTileButton();
            this.txtbarang = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelkonten
            // 
            this.panelkonten.BackColor = System.Drawing.Color.White;
            this.panelkonten.Location = new System.Drawing.Point(149, 65);
            this.panelkonten.Name = "panelkonten";
            this.panelkonten.Size = new System.Drawing.Size(1366, 668);
            this.panelkonten.TabIndex = 0;
            this.panelkonten.Paint += new System.Windows.Forms.PaintEventHandler(this.panelkonten_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.bunifuTileButton1);
            this.panel2.Controls.Add(this.txtkembali);
            this.panel2.Controls.Add(this.bunifuTileButton4);
            this.panel2.Controls.Add(this.txtpinjam);
            this.panel2.Controls.Add(this.txtuser);
            this.panel2.Controls.Add(this.txtbarang);
            this.panel2.Location = new System.Drawing.Point(6, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 664);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1267, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = ".";
            // 
            // txtnamalvl
            // 
            this.txtnamalvl.AutoSize = true;
            this.txtnamalvl.BackColor = System.Drawing.Color.Transparent;
            this.txtnamalvl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamalvl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtnamalvl.Location = new System.Drawing.Point(1165, 21);
            this.txtnamalvl.Name = "txtnamalvl";
            this.txtnamalvl.Size = new System.Drawing.Size(96, 18);
            this.txtnamalvl.TabIndex = 3;
            this.txtnamalvl.Text = "Nama Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(127, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "SMK Inventory";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 735);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 33);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Version 0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Develop By Muhamad Zainal Arifin";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.txtnamalvl);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel1.Controls.Add(this.label5);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(1366, 64);
            this.bunifuShadowPanel1.TabIndex = 4;
            this.bunifuShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuShadowPanel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zainal_PPL_Inventory.Properties.Resources.client_company_502px;
            this.pictureBox1.Location = new System.Drawing.Point(41, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton1.color = System.Drawing.Color.White;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Honeydew;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = global::Zainal_PPL_Inventory.Properties.Resources.click_and_collect_48px;
            this.bunifuTileButton1.ImagePosition = 14;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 29;
            this.bunifuTileButton1.LabelText = "Laporan";
            this.bunifuTileButton1.Location = new System.Drawing.Point(19, 435);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(102, 101);
            this.bunifuTileButton1.TabIndex = 5;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click_1);
            // 
            // txtkembali
            // 
            this.txtkembali.BackColor = System.Drawing.Color.White;
            this.txtkembali.color = System.Drawing.Color.White;
            this.txtkembali.colorActive = System.Drawing.Color.Honeydew;
            this.txtkembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtkembali.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkembali.ForeColor = System.Drawing.Color.Black;
            this.txtkembali.Image = global::Zainal_PPL_Inventory.Properties.Resources.Cloud_Database_48px;
            this.txtkembali.ImagePosition = 14;
            this.txtkembali.ImageZoom = 50;
            this.txtkembali.LabelPosition = 29;
            this.txtkembali.LabelText = "Pengembalian";
            this.txtkembali.Location = new System.Drawing.Point(20, 330);
            this.txtkembali.Margin = new System.Windows.Forms.Padding(4);
            this.txtkembali.Name = "txtkembali";
            this.txtkembali.Size = new System.Drawing.Size(102, 101);
            this.txtkembali.TabIndex = 4;
            this.txtkembali.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.White;
            this.bunifuTileButton4.color = System.Drawing.Color.White;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.Honeydew;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton4.Image = global::Zainal_PPL_Inventory.Properties.Resources.shutdown_50px;
            this.bunifuTileButton4.ImagePosition = 17;
            this.bunifuTileButton4.ImageZoom = 43;
            this.bunifuTileButton4.LabelPosition = 36;
            this.bunifuTileButton4.LabelText = "Keluar";
            this.bunifuTileButton4.Location = new System.Drawing.Point(19, 557);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(102, 97);
            this.bunifuTileButton4.TabIndex = 3;
            this.bunifuTileButton4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // txtpinjam
            // 
            this.txtpinjam.BackColor = System.Drawing.Color.White;
            this.txtpinjam.color = System.Drawing.Color.White;
            this.txtpinjam.colorActive = System.Drawing.Color.Honeydew;
            this.txtpinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtpinjam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpinjam.ForeColor = System.Drawing.Color.Black;
            this.txtpinjam.Image = global::Zainal_PPL_Inventory.Properties.Resources.order_history_48px;
            this.txtpinjam.ImagePosition = 16;
            this.txtpinjam.ImageZoom = 50;
            this.txtpinjam.LabelPosition = 34;
            this.txtpinjam.LabelText = "Peminjaman";
            this.txtpinjam.Location = new System.Drawing.Point(20, 225);
            this.txtpinjam.Margin = new System.Windows.Forms.Padding(4);
            this.txtpinjam.Name = "txtpinjam";
            this.txtpinjam.Size = new System.Drawing.Size(102, 101);
            this.txtpinjam.TabIndex = 2;
            this.txtpinjam.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.color = System.Drawing.Color.White;
            this.txtuser.colorActive = System.Drawing.Color.Honeydew;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.Image = global::Zainal_PPL_Inventory.Properties.Resources.user_group_man_man_50px;
            this.txtuser.ImagePosition = 17;
            this.txtuser.ImageZoom = 50;
            this.txtuser.LabelPosition = 36;
            this.txtuser.LabelText = "Master User";
            this.txtuser.Location = new System.Drawing.Point(20, 121);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(102, 101);
            this.txtuser.TabIndex = 1;
            this.txtuser.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // txtbarang
            // 
            this.txtbarang.BackColor = System.Drawing.Color.White;
            this.txtbarang.color = System.Drawing.Color.White;
            this.txtbarang.colorActive = System.Drawing.Color.Honeydew;
            this.txtbarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtbarang.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarang.ForeColor = System.Drawing.Color.Black;
            this.txtbarang.Image = global::Zainal_PPL_Inventory.Properties.Resources.financial_dynamic_presentation_48px;
            this.txtbarang.ImagePosition = 14;
            this.txtbarang.ImageZoom = 50;
            this.txtbarang.LabelPosition = 29;
            this.txtbarang.LabelText = "Master Barang";
            this.txtbarang.Location = new System.Drawing.Point(20, 17);
            this.txtbarang.Margin = new System.Windows.Forms.Padding(4);
            this.txtbarang.Name = "txtbarang";
            this.txtbarang.Size = new System.Drawing.Size(102, 101);
            this.txtbarang.TabIndex = 0;
            this.txtbarang.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelkonten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmenu";
            this.Load += new System.EventHandler(this.Fmenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void datelbl_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelkonten;
        private Bunifu.Framework.UI.BunifuTileButton txtbarang;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton txtkembali;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton txtpinjam;
        private Bunifu.Framework.UI.BunifuTileButton txtuser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txtnamalvl;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}