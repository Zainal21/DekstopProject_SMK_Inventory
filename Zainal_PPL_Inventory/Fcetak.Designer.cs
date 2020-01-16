namespace Zainal_PPL_Inventory
{
    partial class Fcetak
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.SMKInventoryDBDataSet1 = new Zainal_PPL_Inventory.SMKInventoryDBDataSet1();
            this.pengambalianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengambalianTableAdapter = new Zainal_PPL_Inventory.SMKInventoryDBDataSet1TableAdapters.pengambalianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SMKInventoryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambalianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pengambalianBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Zainal_PPL_Inventory.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(54, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(894, 436);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan";
            // 
            // SMKInventoryDBDataSet1
            // 
            this.SMKInventoryDBDataSet1.DataSetName = "SMKInventoryDBDataSet1";
            this.SMKInventoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengambalianBindingSource
            // 
            this.pengambalianBindingSource.DataMember = "pengambalian";
            this.pengambalianBindingSource.DataSource = this.SMKInventoryDBDataSet1;
            // 
            // pengambalianTableAdapter
            // 
            this.pengambalianTableAdapter.ClearBeforeFill = true;
            // 
            // Fcetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Fcetak";
            this.Text = "Fcetak";
            this.Load += new System.EventHandler(this.Fcetak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SMKInventoryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambalianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pengambalianBindingSource;
        private SMKInventoryDBDataSet1 SMKInventoryDBDataSet1;
        private SMKInventoryDBDataSet1TableAdapters.pengambalianTableAdapter pengambalianTableAdapter;
    }
}