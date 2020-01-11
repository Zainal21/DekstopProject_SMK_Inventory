namespace Zainal_PPL_Inventory
{
    partial class UCMasterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMasterUser));
            this.cbrole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gduser = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtnama = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtpass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtusername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtid = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.gduser)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbrole
            // 
            this.cbrole.FormattingEnabled = true;
            this.cbrole.Items.AddRange(new object[] {
            "Adminstrator",
            "Peminjam",
            "Operator",
            "Owner"});
            this.cbrole.Location = new System.Drawing.Point(653, 170);
            this.cbrole.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbrole.Name = "cbrole";
            this.cbrole.Size = new System.Drawing.Size(279, 21);
            this.cbrole.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(649, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(154, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 39);
            this.label5.TabIndex = 39;
            this.label5.Text = "Master Data User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(343, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID ";
            // 
            // gduser
            // 
            this.gduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gduser.Location = new System.Drawing.Point(31, 293);
            this.gduser.Name = "gduser";
            this.gduser.Size = new System.Drawing.Size(1102, 247);
            this.gduser.TabIndex = 29;
            this.gduser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gduser_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(343, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nama";
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuShadowPanel1.Controls.Add(this.label5);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(265, 41);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(617, 62);
            this.bunifuShadowPanel1.TabIndex = 45;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Hapus";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(938, 224);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(126, 42);
            this.bunifuFlatButton5.TabIndex = 48;
            this.bunifuFlatButton5.Text = "Hapus";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ubah";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(793, 224);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(126, 42);
            this.bunifuFlatButton1.TabIndex = 47;
            this.bunifuFlatButton1.Text = "Ubah";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Tambah";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(644, 224);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(133, 42);
            this.bunifuFlatButton4.TabIndex = 46;
            this.bunifuFlatButton4.Text = "Tambah";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // txtnama
            // 
            this.txtnama.AcceptsReturn = false;
            this.txtnama.AcceptsTab = false;
            this.txtnama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnama.BackColor = System.Drawing.Color.Transparent;
            this.txtnama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtnama.BackgroundImage")));
            this.txtnama.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtnama.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtnama.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtnama.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtnama.BorderRadius = 1;
            this.txtnama.BorderThickness = 2;
            this.txtnama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnama.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama.DefaultText = "";
            this.txtnama.FillColor = System.Drawing.Color.White;
            this.txtnama.HideSelection = true;
            this.txtnama.IconLeft = null;
            this.txtnama.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtnama.IconPadding = 10;
            this.txtnama.IconRight = null;
            this.txtnama.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtnama.Location = new System.Drawing.Point(336, 231);
            this.txtnama.MaxLength = 32767;
            this.txtnama.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtnama.Modified = false;
            this.txtnama.Name = "txtnama";
            this.txtnama.PasswordChar = '\0';
            this.txtnama.ReadOnly = false;
            this.txtnama.SelectedText = "";
            this.txtnama.SelectionLength = 0;
            this.txtnama.SelectionStart = 0;
            this.txtnama.ShortcutsEnabled = true;
            this.txtnama.Size = new System.Drawing.Size(279, 35);
            this.txtnama.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtnama.TabIndex = 44;
            this.txtnama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnama.TextMarginLeft = 5;
            this.txtnama.TextPlaceholder = "";
            this.txtnama.UseSystemPasswordChar = false;
            // 
            // txtpass
            // 
            this.txtpass.AcceptsReturn = false;
            this.txtpass.AcceptsTab = false;
            this.txtpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpass.BackColor = System.Drawing.Color.Transparent;
            this.txtpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpass.BackgroundImage")));
            this.txtpass.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtpass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtpass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtpass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtpass.BorderRadius = 1;
            this.txtpass.BorderThickness = 2;
            this.txtpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpass.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.DefaultText = "";
            this.txtpass.FillColor = System.Drawing.Color.White;
            this.txtpass.HideSelection = true;
            this.txtpass.IconLeft = null;
            this.txtpass.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtpass.IconPadding = 10;
            this.txtpass.IconRight = null;
            this.txtpass.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtpass.Location = new System.Drawing.Point(336, 170);
            this.txtpass.MaxLength = 32767;
            this.txtpass.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtpass.Modified = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.ReadOnly = false;
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.ShortcutsEnabled = true;
            this.txtpass.Size = new System.Drawing.Size(279, 35);
            this.txtpass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtpass.TabIndex = 42;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.TextMarginLeft = 5;
            this.txtpass.TextPlaceholder = "";
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // txtusername
            // 
            this.txtusername.AcceptsReturn = false;
            this.txtusername.AcceptsTab = false;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtusername.BackgroundImage")));
            this.txtusername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtusername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtusername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtusername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtusername.BorderRadius = 1;
            this.txtusername.BorderThickness = 2;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.DefaultText = "";
            this.txtusername.FillColor = System.Drawing.Color.White;
            this.txtusername.HideSelection = true;
            this.txtusername.IconLeft = null;
            this.txtusername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.IconPadding = 10;
            this.txtusername.IconRight = null;
            this.txtusername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtusername.Location = new System.Drawing.Point(37, 231);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtusername.Modified = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.ReadOnly = false;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(279, 35);
            this.txtusername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtusername.TabIndex = 31;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.TextMarginLeft = 5;
            this.txtusername.TextPlaceholder = "";
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // txtid
            // 
            this.txtid.AcceptsReturn = false;
            this.txtid.AcceptsTab = false;
            this.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtid.BackColor = System.Drawing.Color.Transparent;
            this.txtid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtid.BackgroundImage")));
            this.txtid.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtid.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtid.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.txtid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtid.BorderRadius = 1;
            this.txtid.BorderThickness = 2;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtid.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.DefaultText = "";
            this.txtid.FillColor = System.Drawing.Color.White;
            this.txtid.HideSelection = true;
            this.txtid.IconLeft = null;
            this.txtid.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtid.IconPadding = 10;
            this.txtid.IconRight = null;
            this.txtid.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtid.Location = new System.Drawing.Point(37, 170);
            this.txtid.MaxLength = 32767;
            this.txtid.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtid.Modified = false;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.ReadOnly = false;
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.ShortcutsEnabled = true;
            this.txtid.Size = new System.Drawing.Size(279, 35);
            this.txtid.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtid.TabIndex = 30;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtid.TextMarginLeft = 5;
            this.txtid.TextPlaceholder = "";
            this.txtid.UseSystemPasswordChar = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 5;
            this.bunifuFlatButton2.ButtonText = "REFRESH";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Zainal_PPL_Inventory.Properties.Resources.icons8_synchronize_60px;
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(940, 170);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(124, 35);
            this.bunifuFlatButton2.TabIndex = 49;
            this.bunifuFlatButton2.Text = "REFRESH";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // UCMasterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.cbrole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.gduser);
            this.Name = "UCMasterUser";
            this.Size = new System.Drawing.Size(1366, 668);
            this.Load += new System.EventHandler(this.UCMasterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gduser)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bunifuFlatButton2_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void bunifuFlatButton3_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void bunifuFlatButton1_Click(object sender, System.EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.ComboBox cbrole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtusername;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtid;
        private System.Windows.Forms.DataGridView gduser;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtpass;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtnama;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
