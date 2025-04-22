namespace InglesEscuela
{
    partial class FCalifica
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
            System.Windows.Forms.Label tutorLabel;
            System.Windows.Forms.Label nombreAluLabel;
            this.TapC1 = new System.Windows.Forms.TabControl();
            this.TP1 = new System.Windows.Forms.TabPage();
            this.conCalGenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conCalGenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDBDataSet = new InglesEscuela.AlumnosDBDataSet();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tutorTextBox = new System.Windows.Forms.TextBox();
            this.TP2 = new System.Windows.Forms.TabPage();
            this.calificacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bcancel = new System.Windows.Forms.Button();
            this.Bsave = new System.Windows.Forms.Button();
            this.Bedit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nombreAluTextBox = new System.Windows.Forms.TextBox();
            this.conCalGenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager();
            this.conCalGenTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.ConCalGenTableAdapter();
            this.calificacionesTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.CalificacionesTableAdapter();
            tutorLabel = new System.Windows.Forms.Label();
            nombreAluLabel = new System.Windows.Forms.Label();
            this.TapC1.SuspendLayout();
            this.TP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.TP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorLabel
            // 
            tutorLabel.AutoSize = true;
            tutorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tutorLabel.Location = new System.Drawing.Point(45, 39);
            tutorLabel.Name = "tutorLabel";
            tutorLabel.Size = new System.Drawing.Size(82, 29);
            tutorLabel.TabIndex = 0;
            tutorLabel.Text = "Tutor:";
            // 
            // nombreAluLabel
            // 
            nombreAluLabel.AutoSize = true;
            nombreAluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreAluLabel.Location = new System.Drawing.Point(23, 36);
            nombreAluLabel.Name = "nombreAluLabel";
            nombreAluLabel.Size = new System.Drawing.Size(92, 25);
            nombreAluLabel.TabIndex = 0;
            nombreAluLabel.Text = "Alumno:";
            // 
            // TapC1
            // 
            this.TapC1.Controls.Add(this.TP1);
            this.TapC1.Controls.Add(this.TP2);
            this.TapC1.Location = new System.Drawing.Point(12, 12);
            this.TapC1.Name = "TapC1";
            this.TapC1.SelectedIndex = 0;
            this.TapC1.Size = new System.Drawing.Size(1365, 679);
            this.TapC1.TabIndex = 0;
            this.TapC1.SelectedIndexChanged += new System.EventHandler(this.TapC1_SelectedIndexChanged);
            // 
            // TP1
            // 
            this.TP1.AutoScroll = true;
            this.TP1.Controls.Add(this.conCalGenDataGridView);
            this.TP1.Controls.Add(this.alumnosDataGridView);
            this.TP1.Controls.Add(this.panel1);
            this.TP1.Location = new System.Drawing.Point(4, 29);
            this.TP1.Name = "TP1";
            this.TP1.Padding = new System.Windows.Forms.Padding(3);
            this.TP1.Size = new System.Drawing.Size(1357, 646);
            this.TP1.TabIndex = 0;
            this.TP1.Text = "Consulta";
            this.TP1.UseVisualStyleBackColor = true;
            // 
            // conCalGenDataGridView
            // 
            this.conCalGenDataGridView.AllowUserToAddRows = false;
            this.conCalGenDataGridView.AllowUserToDeleteRows = false;
            this.conCalGenDataGridView.AutoGenerateColumns = false;
            this.conCalGenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conCalGenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn13});
            this.conCalGenDataGridView.DataSource = this.conCalGenBindingSource1;
            this.conCalGenDataGridView.Location = new System.Drawing.Point(309, 150);
            this.conCalGenDataGridView.Name = "conCalGenDataGridView";
            this.conCalGenDataGridView.ReadOnly = true;
            this.conCalGenDataGridView.RowHeadersVisible = false;
            this.conCalGenDataGridView.RowHeadersWidth = 62;
            this.conCalGenDataGridView.RowTemplate.Height = 28;
            this.conCalGenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conCalGenDataGridView.Size = new System.Drawing.Size(1015, 367);
            this.conCalGenDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nivel";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Calificación";
            this.dataGridViewTextBoxColumn6.HeaderText = "Calificación";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "NombrePro";
            this.dataGridViewTextBoxColumn13.HeaderText = "Profesor";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // conCalGenBindingSource1
            // 
            this.conCalGenBindingSource1.DataMember = "Alumnos_ConCalGen";
            this.conCalGenBindingSource1.DataSource = this.alumnosBindingSource;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.alumnosDBDataSet;
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosDataGridView
            // 
            this.alumnosDataGridView.AllowUserToAddRows = false;
            this.alumnosDataGridView.AllowUserToDeleteRows = false;
            this.alumnosDataGridView.AutoGenerateColumns = false;
            this.alumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.alumnosDataGridView.DataSource = this.alumnosBindingSource;
            this.alumnosDataGridView.Location = new System.Drawing.Point(6, 22);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.ReadOnly = true;
            this.alumnosDataGridView.RowHeadersVisible = false;
            this.alumnosDataGridView.RowHeadersWidth = 62;
            this.alumnosDataGridView.RowTemplate.Height = 28;
            this.alumnosDataGridView.Size = new System.Drawing.Size(280, 495);
            this.alumnosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreAlu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(tutorLabel);
            this.panel1.Controls.Add(this.tutorTextBox);
            this.panel1.Location = new System.Drawing.Point(309, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 1;
            // 
            // tutorTextBox
            // 
            this.tutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Tutor", true));
            this.tutorTextBox.Location = new System.Drawing.Point(133, 43);
            this.tutorTextBox.Name = "tutorTextBox";
            this.tutorTextBox.Size = new System.Drawing.Size(336, 26);
            this.tutorTextBox.TabIndex = 1;
            // 
            // TP2
            // 
            this.TP2.Controls.Add(this.calificacionesDataGridView);
            this.TP2.Controls.Add(this.panel2);
            this.TP2.Controls.Add(this.panel3);
            this.TP2.Location = new System.Drawing.Point(4, 29);
            this.TP2.Name = "TP2";
            this.TP2.Padding = new System.Windows.Forms.Padding(3);
            this.TP2.Size = new System.Drawing.Size(1357, 646);
            this.TP2.TabIndex = 1;
            this.TP2.Text = "Editar";
            this.TP2.UseVisualStyleBackColor = true;
            // 
            // calificacionesDataGridView
            // 
            this.calificacionesDataGridView.AutoGenerateColumns = false;
            this.calificacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calificacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column1,
            this.Column2});
            this.calificacionesDataGridView.DataSource = this.calificacionesBindingSource;
            this.calificacionesDataGridView.Enabled = false;
            this.calificacionesDataGridView.Location = new System.Drawing.Point(36, 159);
            this.calificacionesDataGridView.Name = "calificacionesDataGridView";
            this.calificacionesDataGridView.RowHeadersWidth = 62;
            this.calificacionesDataGridView.RowTemplate.Height = 28;
            this.calificacionesDataGridView.Size = new System.Drawing.Size(1290, 436);
            this.calificacionesDataGridView.TabIndex = 2;
            this.calificacionesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calificacionesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Calificación";
            this.dataGridViewTextBoxColumn7.HeaderText = "Calificación";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "idProfesor";
            this.dataGridViewTextBoxColumn8.HeaderText = "idProfesor";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdUsuario";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdUsuario";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Profesor ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nivel";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // calificacionesBindingSource
            // 
            this.calificacionesBindingSource.DataMember = "Alumnos_Calificaciones";
            this.calificacionesBindingSource.DataSource = this.alumnosBindingSource;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Bcancel);
            this.panel3.Controls.Add(this.Bsave);
            this.panel3.Controls.Add(this.Bedit);
            this.panel3.Location = new System.Drawing.Point(750, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 100);
            this.panel3.TabIndex = 1;
            // 
            // Bcancel
            // 
            this.Bcancel.Enabled = false;
            this.Bcancel.Image = global::InglesEscuela.Properties.Resources.cancelar__1_;
            this.Bcancel.Location = new System.Drawing.Point(434, 11);
            this.Bcancel.Name = "Bcancel";
            this.Bcancel.Size = new System.Drawing.Size(104, 79);
            this.Bcancel.TabIndex = 2;
            this.Bcancel.UseVisualStyleBackColor = true;
            this.Bcancel.Click += new System.EventHandler(this.Bcancel_Click);
            // 
            // Bsave
            // 
            this.Bsave.Enabled = false;
            this.Bsave.Image = global::InglesEscuela.Properties.Resources.simbolo_de_formato_de_archivo_sav__1_;
            this.Bsave.Location = new System.Drawing.Point(241, 10);
            this.Bsave.Name = "Bsave";
            this.Bsave.Size = new System.Drawing.Size(104, 79);
            this.Bsave.TabIndex = 1;
            this.Bsave.UseVisualStyleBackColor = true;
            // 
            // Bedit
            // 
            this.Bedit.Image = global::InglesEscuela.Properties.Resources.curriculum__1_;
            this.Bedit.Location = new System.Drawing.Point(64, 11);
            this.Bedit.Name = "Bedit";
            this.Bedit.Size = new System.Drawing.Size(104, 79);
            this.Bedit.TabIndex = 0;
            this.Bedit.UseVisualStyleBackColor = true;
            this.Bedit.Click += new System.EventHandler(this.Bedit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(nombreAluLabel);
            this.panel2.Controls.Add(this.nombreAluTextBox);
            this.panel2.Location = new System.Drawing.Point(36, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 100);
            this.panel2.TabIndex = 0;
            // 
            // nombreAluTextBox
            // 
            this.nombreAluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NombreAlu", true));
            this.nombreAluTextBox.Location = new System.Drawing.Point(125, 36);
            this.nombreAluTextBox.Name = "nombreAluTextBox";
            this.nombreAluTextBox.Size = new System.Drawing.Size(381, 26);
            this.nombreAluTextBox.TabIndex = 1;
            // 
            // conCalGenBindingSource
            // 
            this.conCalGenBindingSource.DataMember = "ConCalGen";
            this.conCalGenBindingSource.DataSource = this.alumnosDBDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalificacionesTableAdapter = null;
            this.tableAdapterManager.GradoTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // conCalGenTableAdapter
            // 
            this.conCalGenTableAdapter.ClearBeforeFill = true;
            // 
            // calificacionesTableAdapter
            // 
            this.calificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // FCalifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 721);
            this.Controls.Add(this.TapC1);
            this.Name = "FCalifica";
            this.Text = "FCalifica";
            this.Load += new System.EventHandler(this.FCalifica_Load);
            this.TapC1.ResumeLayout(false);
            this.TP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conCalGenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TapC1;
        private System.Windows.Forms.TabPage TP1;
        private System.Windows.Forms.TabPage TP2;
        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private AlumnosDBDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private AlumnosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tutorTextBox;
        private System.Windows.Forms.BindingSource conCalGenBindingSource;
        private AlumnosDBDataSetTableAdapters.ConCalGenTableAdapter conCalGenTableAdapter;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private System.Windows.Forms.DataGridView conCalGenDataGridView;
        private System.Windows.Forms.BindingSource conCalGenBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nombreAluTextBox;
        private System.Windows.Forms.BindingSource calificacionesBindingSource;
        private AlumnosDBDataSetTableAdapters.CalificacionesTableAdapter calificacionesTableAdapter;
        private System.Windows.Forms.DataGridView calificacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Bedit;
        private System.Windows.Forms.Button Bsave;
        private System.Windows.Forms.Button Bcancel;
    }
}