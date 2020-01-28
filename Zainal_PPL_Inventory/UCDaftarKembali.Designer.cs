namespace Zainal_PPL_Inventory
{
    partial class UCDaftarKembali
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnkembalikan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.label5);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(238, 33);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(661, 62);
            this.bunifuShadowPanel1.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(640, 39);
            this.label5.TabIndex = 39;
            this.label5.Text = "Daftar barang yang telah dikembalikan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1036, 406);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnkembalikan
            // 
            this.btnkembalikan.Active = false;
            this.btnkembalikan.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnkembalikan.BackColor = System.Drawing.Color.DarkRed;
            this.btnkembalikan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkembalikan.BorderRadius = 5;
            this.btnkembalikan.ButtonText = "Refresh";
            this.btnkembalikan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkembalikan.DisabledColor = System.Drawing.Color.Gray;
            this.btnkembalikan.ForeColor = System.Drawing.Color.White;
            this.btnkembalikan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnkembalikan.Iconimage = global::Zainal_PPL_Inventory.Properties.Resources.circled_chevron_left_50px1;
            this.btnkembalikan.Iconimage_right = null;
            this.btnkembalikan.Iconimage_right_Selected = null;
            this.btnkembalikan.Iconimage_Selected = null;
            this.btnkembalikan.IconMarginLeft = 0;
            this.btnkembalikan.IconMarginRight = 0;
            this.btnkembalikan.IconRightVisible = true;
            this.btnkembalikan.IconRightZoom = 0D;
            this.btnkembalikan.IconVisible = true;
            this.btnkembalikan.IconZoom = 50D;
            this.btnkembalikan.IsTab = false;
            this.btnkembalikan.Location = new System.Drawing.Point(548, 566);
            this.btnkembalikan.Name = "btnkembalikan";
            this.btnkembalikan.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnkembalikan.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnkembalikan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnkembalikan.selected = false;
            this.btnkembalikan.Size = new System.Drawing.Size(179, 53);
            this.btnkembalikan.TabIndex = 49;
            this.btnkembalikan.Text = "Refresh";
            this.btnkembalikan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnkembalikan.Textcolor = System.Drawing.Color.White;
            this.btnkembalikan.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkembalikan.Click += new System.EventHandler(this.btnkembalikan_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "Cetak";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Zainal_PPL_Inventory.Properties.Resources.circled_chevron_left_50px1;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(338, 566);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(179, 53);
            this.bunifuFlatButton2.TabIndex = 50;
            this.bunifuFlatButton2.Text = "Cetak";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // UCDaftarKembali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnkembalikan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Name = "UCDaftarKembali";
            this.Size = new System.Drawing.Size(1366, 668);
            this.Load += new System.EventHandler(this.UCDaftarKembali_Load);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton btnkembalikan;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
