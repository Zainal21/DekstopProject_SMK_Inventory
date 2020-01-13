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
            this.SMKInventoryDBDataSet = new Zainal_PPL_Inventory.SMKInventoryDBDataSet();
            this.pengambalianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengambalianTableAdapter = new Zainal_PPL_Inventory.SMKInventoryDBDataSetTableAdapters.pengambalianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SMKInventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambalianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pengambalianBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.Size = new System.Drawing.Size(876, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // SMKInventoryDBDataSet
            // 
            this.SMKInventoryDBDataSet.DataSetName = "SMKInventoryDBDataSet";
            this.SMKInventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengambalianBindingSource
            // 
            this.pengambalianBindingSource.DataMember = "pengambalian";
            this.pengambalianBindingSource.DataSource = this.SMKInventoryDBDataSet;
            // 
            // pengambalianTableAdapter
            // 
            this.pengambalianTableAdapter.ClearBeforeFill = true;
            // 
            // Fcetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 520);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Fcetak";
            this.Text = "Fcetak";
            this.Load += new System.EventHandler(this.Fcetak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SMKInventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambalianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pengambalianBindingSource;
        private SMKInventoryDBDataSet SMKInventoryDBDataSet;
        private SMKInventoryDBDataSetTableAdapters.pengambalianTableAdapter pengambalianTableAdapter;
    }
}