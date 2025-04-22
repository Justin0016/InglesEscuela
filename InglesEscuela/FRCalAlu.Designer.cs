namespace InglesEscuela
{
    partial class FRCalAlu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.alumnosDBDataSet = new InglesEscuela.AlumnosDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConCalAluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conCalAluTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.ConCalAluTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConCalAluBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ConCalAluBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InglesEscuela.RCalAlu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1057, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConCalAluBindingSource
            // 
            this.ConCalAluBindingSource.DataMember = "ConCalAlu";
            this.ConCalAluBindingSource.DataSource = this.alumnosDBDataSet;
            // 
            // conCalAluTableAdapter
            // 
            this.conCalAluTableAdapter.ClearBeforeFill = true;
            // 
            // FRCalAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 705);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRCalAlu";
            this.Text = "FRCalAlu";
            this.Load += new System.EventHandler(this.FRCalAlu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConCalAluBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource ConCalAluBindingSource;
        private AlumnosDBDataSetTableAdapters.ConCalAluTableAdapter conCalAluTableAdapter;
    }
}