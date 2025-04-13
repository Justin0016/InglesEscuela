namespace InglesEscuela
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idAlumnoLabel;
            System.Windows.Forms.Label nombreAluLabel;
            System.Windows.Forms.Label fechNacLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label tutorLabel;
            this.alumnosDBDataSet = new InglesEscuela.AlumnosDBDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager();
            this.alumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alumnosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.nombreAluTextBox = new System.Windows.Forms.TextBox();
            this.fechNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tutorTextBox = new System.Windows.Forms.TextBox();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idAlumnoLabel = new System.Windows.Forms.Label();
            nombreAluLabel = new System.Windows.Forms.Label();
            fechNacLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            tutorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).BeginInit();
            this.alumnosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.alumnosDBDataSet;
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
            this.tableAdapterManager.MateriasTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // alumnosBindingNavigator
            // 
            this.alumnosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alumnosBindingNavigator.BindingSource = this.alumnosBindingSource;
            this.alumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alumnosBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.alumnosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alumnosBindingNavigatorSaveItem});
            this.alumnosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnosBindingNavigator.Name = "alumnosBindingNavigator";
            this.alumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnosBindingNavigator.Size = new System.Drawing.Size(1212, 33);
            this.alumnosBindingNavigator.TabIndex = 0;
            this.alumnosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 25);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // alumnosBindingNavigatorSaveItem
            // 
            this.alumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alumnosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosBindingNavigatorSaveItem.Image")));
            this.alumnosBindingNavigatorSaveItem.Name = "alumnosBindingNavigatorSaveItem";
            this.alumnosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.alumnosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.alumnosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alumnosBindingNavigatorSaveItem_Click);
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new System.Drawing.Point(649, 173);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(85, 20);
            idAlumnoLabel.TabIndex = 1;
            idAlumnoLabel.Text = "Id Alumno:";
            // 
            // idAlumnoTextBox
            // 
            this.idAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "IdAlumno", true));
            this.idAlumnoTextBox.Location = new System.Drawing.Point(751, 173);
            this.idAlumnoTextBox.Name = "idAlumnoTextBox";
            this.idAlumnoTextBox.Size = new System.Drawing.Size(200, 26);
            this.idAlumnoTextBox.TabIndex = 2;
            // 
            // nombreAluLabel
            // 
            nombreAluLabel.AutoSize = true;
            nombreAluLabel.Location = new System.Drawing.Point(649, 205);
            nombreAluLabel.Name = "nombreAluLabel";
            nombreAluLabel.Size = new System.Drawing.Size(96, 20);
            nombreAluLabel.TabIndex = 3;
            nombreAluLabel.Text = "Nombre Alu:";
            // 
            // nombreAluTextBox
            // 
            this.nombreAluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NombreAlu", true));
            this.nombreAluTextBox.Location = new System.Drawing.Point(751, 202);
            this.nombreAluTextBox.Name = "nombreAluTextBox";
            this.nombreAluTextBox.Size = new System.Drawing.Size(200, 26);
            this.nombreAluTextBox.TabIndex = 4;
            // 
            // fechNacLabel
            // 
            fechNacLabel.AutoSize = true;
            fechNacLabel.Location = new System.Drawing.Point(649, 238);
            fechNacLabel.Name = "fechNacLabel";
            fechNacLabel.Size = new System.Drawing.Size(81, 20);
            fechNacLabel.TabIndex = 5;
            fechNacLabel.Text = "Fech Nac:";
            // 
            // fechNacDateTimePicker
            // 
            this.fechNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "FechNac", true));
            this.fechNacDateTimePicker.Location = new System.Drawing.Point(751, 234);
            this.fechNacDateTimePicker.Name = "fechNacDateTimePicker";
            this.fechNacDateTimePicker.Size = new System.Drawing.Size(253, 26);
            this.fechNacDateTimePicker.TabIndex = 6;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(649, 269);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(751, 266);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 26);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(649, 301);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(751, 298);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // tutorLabel
            // 
            tutorLabel.AutoSize = true;
            tutorLabel.Location = new System.Drawing.Point(649, 333);
            tutorLabel.Name = "tutorLabel";
            tutorLabel.Size = new System.Drawing.Size(50, 20);
            tutorLabel.TabIndex = 11;
            tutorLabel.Text = "Tutor:";
            // 
            // tutorTextBox
            // 
            this.tutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Tutor", true));
            this.tutorTextBox.Location = new System.Drawing.Point(751, 330);
            this.tutorTextBox.Name = "tutorTextBox";
            this.tutorTextBox.Size = new System.Drawing.Size(200, 26);
            this.tutorTextBox.TabIndex = 12;
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
            this.alumnosDataGridView.Location = new System.Drawing.Point(155, 136);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.ReadOnly = true;
            this.alumnosDataGridView.RowHeadersWidth = 62;
            this.alumnosDataGridView.RowTemplate.Height = 28;
            this.alumnosDataGridView.Size = new System.Drawing.Size(300, 220);
            this.alumnosDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreAlu";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreAlu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 696);
            this.Controls.Add(this.alumnosDataGridView);
            this.Controls.Add(idAlumnoLabel);
            this.Controls.Add(this.idAlumnoTextBox);
            this.Controls.Add(nombreAluLabel);
            this.Controls.Add(this.nombreAluTextBox);
            this.Controls.Add(fechNacLabel);
            this.Controls.Add(this.fechNacDateTimePicker);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(tutorLabel);
            this.Controls.Add(this.tutorTextBox);
            this.Controls.Add(this.alumnosBindingNavigator);
            this.Name = "Form1";
            this.Text = "Catalogo Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).EndInit();
            this.alumnosBindingNavigator.ResumeLayout(false);
            this.alumnosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private AlumnosDBDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private AlumnosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alumnosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idAlumnoTextBox;
        private System.Windows.Forms.TextBox nombreAluTextBox;
        private System.Windows.Forms.DateTimePicker fechNacDateTimePicker;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox tutorTextBox;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

