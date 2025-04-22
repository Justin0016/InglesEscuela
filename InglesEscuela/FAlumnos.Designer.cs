using System;
using System.Windows.Forms;

namespace InglesEscuela
{
    partial class FAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAlumnos));
            this.alumnosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDBDataSet = new InglesEscuela.AlumnosDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.guardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pegarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbProm = new System.Windows.Forms.Label();
            this.idAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.Bprom = new System.Windows.Forms.Button();
            this.LbId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.nombreAluTextBox = new System.Windows.Forms.TextBox();
            this.tutorTextBox = new System.Windows.Forms.TextBox();
            this.tutorLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fechNacLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.fechNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conCalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conCalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LbFoto = new System.Windows.Forms.Label();
            this.alumnosTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager = new InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager();
            this.conCalTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.ConCalTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.Bprint = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.Bnuevo = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).BeginInit();
            this.alumnosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosBindingNavigator
            // 
            this.alumnosBindingNavigator.AddNewItem = null;
            this.alumnosBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.alumnosBindingNavigator.AutoSize = false;
            this.alumnosBindingNavigator.BindingSource = this.alumnosBindingSource;
            this.alumnosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnosBindingNavigator.DeleteItem = null;
            this.alumnosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.nuevoToolStripButton,
            this.abrirToolStripButton,
            this.guardarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.cortarToolStripButton,
            this.copiarToolStripButton,
            this.pegarToolStripButton,
            this.toolStripSeparator1,
            this.ayudaToolStripButton});
            this.alumnosBindingNavigator.Location = new System.Drawing.Point(38, 413);
            this.alumnosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnosBindingNavigator.Name = "alumnosBindingNavigator";
            this.alumnosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnosBindingNavigator.Size = new System.Drawing.Size(369, 61);
            this.alumnosBindingNavigator.TabIndex = 0;
            this.alumnosBindingNavigator.Text = "bindingNavigator1";
            this.alumnosBindingNavigator.RefreshItems += new System.EventHandler(this.alumnosBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 56);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::InglesEscuela.Properties.Resources.atras;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 56);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::InglesEscuela.Properties.Resources.esquema_de_boton_circular_de_flecha_hacia_atras_izquierda;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 56);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 61);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::InglesEscuela.Properties.Resources.flecha_correcta;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 56);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Checked = true;
            this.bindingNavigatorMoveLastItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigatorMoveLastItem.Image = global::InglesEscuela.Properties.Resources.reproducir_flecha;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 56);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // nuevoToolStripButton
            // 
            this.nuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripButton.Image")));
            this.nuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripButton.Name = "nuevoToolStripButton";
            this.nuevoToolStripButton.Size = new System.Drawing.Size(34, 56);
            this.nuevoToolStripButton.Text = "&Nuevo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // guardarToolStripButton
            // 
            this.guardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton.Image")));
            this.guardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton.Name = "guardarToolStripButton";
            this.guardarToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // cortarToolStripButton
            // 
            this.cortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripButton.Image")));
            this.cortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripButton.Name = "cortarToolStripButton";
            this.cortarToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.cortarToolStripButton.Text = "Cort&ar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            this.pegarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripButton.Image")));
            this.pegarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripButton.Name = "pegarToolStripButton";
            this.pegarToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // ayudaToolStripButton
            // 
            this.ayudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripButton.Image")));
            this.ayudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayudaToolStripButton.Name = "ayudaToolStripButton";
            this.ayudaToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.ayudaToolStripButton.Text = "Ay&uda";
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
            this.alumnosDataGridView.Location = new System.Drawing.Point(38, 32);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.ReadOnly = true;
            this.alumnosDataGridView.RowHeadersWidth = 62;
            this.alumnosDataGridView.RowTemplate.Height = 28;
            this.alumnosDataGridView.Size = new System.Drawing.Size(369, 348);
            this.alumnosDataGridView.TabIndex = 13;
            this.alumnosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alumnosDataGridView_CellContentClick);
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
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.LbProm);
            this.panel1.Controls.Add(this.idAlumnoTextBox);
            this.panel1.Controls.Add(this.Bprom);
            this.panel1.Controls.Add(this.LbId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LbNombre);
            this.panel1.Controls.Add(this.nombreAluTextBox);
            this.panel1.Controls.Add(this.tutorTextBox);
            this.panel1.Controls.Add(this.tutorLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(this.fechNacLabel);
            this.panel1.Controls.Add(this.telefonoLabel);
            this.panel1.Controls.Add(this.fechNacDateTimePicker);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(478, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 471);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LbProm
            // 
            this.LbProm.AutoSize = true;
            this.LbProm.Location = new System.Drawing.Point(344, 48);
            this.LbProm.Name = "LbProm";
            this.LbProm.Size = new System.Drawing.Size(0, 25);
            this.LbProm.TabIndex = 27;
            // 
            // idAlumnoTextBox
            // 
            this.idAlumnoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "IdAlumno", true));
            this.idAlumnoTextBox.Location = new System.Drawing.Point(18, 45);
            this.idAlumnoTextBox.MaxLength = 12;
            this.idAlumnoTextBox.Name = "idAlumnoTextBox";
            this.idAlumnoTextBox.Size = new System.Drawing.Size(200, 30);
            this.idAlumnoTextBox.TabIndex = 2;
            this.idAlumnoTextBox.TextChanged += new System.EventHandler(this.idAlumnoTextBox_TextChanged);
            // 
            // Bprom
            // 
            this.Bprom.Location = new System.Drawing.Point(312, 78);
            this.Bprom.Name = "Bprom";
            this.Bprom.Size = new System.Drawing.Size(113, 23);
            this.Bprom.TabIndex = 26;
            this.Bprom.UseVisualStyleBackColor = true;
            this.Bprom.Click += new System.EventHandler(this.Bprom_Click);
            // 
            // LbId
            // 
            this.LbId.AutoSize = true;
            this.LbId.BackColor = System.Drawing.SystemColors.Control;
            this.LbId.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbId.Location = new System.Drawing.Point(21, 16);
            this.LbId.Name = "LbId";
            this.LbId.Size = new System.Drawing.Size(47, 26);
            this.LbId.TabIndex = 17;
            this.LbId.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Promedio";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.BackColor = System.Drawing.SystemColors.Control;
            this.LbNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(21, 89);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(107, 26);
            this.LbNombre.TabIndex = 18;
            this.LbNombre.Text = "Nombre:";
            // 
            // nombreAluTextBox
            // 
            this.nombreAluTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nombreAluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "NombreAlu", true));
            this.nombreAluTextBox.Location = new System.Drawing.Point(18, 121);
            this.nombreAluTextBox.MaxLength = 255;
            this.nombreAluTextBox.Name = "nombreAluTextBox";
            this.nombreAluTextBox.Size = new System.Drawing.Size(278, 30);
            this.nombreAluTextBox.TabIndex = 4;
            this.nombreAluTextBox.TextChanged += new System.EventHandler(this.nombreAluTextBox_TextChanged);
            // 
            // tutorTextBox
            // 
            this.tutorTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tutorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Tutor", true));
            this.tutorTextBox.Location = new System.Drawing.Point(18, 416);
            this.tutorTextBox.MaxLength = 255;
            this.tutorTextBox.Name = "tutorTextBox";
            this.tutorTextBox.Size = new System.Drawing.Size(278, 30);
            this.tutorTextBox.TabIndex = 12;
            // 
            // tutorLabel
            // 
            this.tutorLabel.AutoSize = true;
            this.tutorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.tutorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorLabel.Location = new System.Drawing.Point(21, 387);
            this.tutorLabel.Name = "tutorLabel";
            this.tutorLabel.Size = new System.Drawing.Size(81, 26);
            this.tutorLabel.TabIndex = 11;
            this.tutorLabel.Text = "Tutor:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(18, 340);
            this.emailTextBox.MaxLength = 200;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 30);
            this.emailTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(21, 311);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(83, 26);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Email:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(18, 266);
            this.telefonoTextBox.MaxLength = 10;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 30);
            this.telefonoTextBox.TabIndex = 8;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // fechNacLabel
            // 
            this.fechNacLabel.AutoSize = true;
            this.fechNacLabel.BackColor = System.Drawing.SystemColors.Control;
            this.fechNacLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechNacLabel.Location = new System.Drawing.Point(21, 165);
            this.fechNacLabel.Name = "fechNacLabel";
            this.fechNacLabel.Size = new System.Drawing.Size(217, 26);
            this.fechNacLabel.TabIndex = 5;
            this.fechNacLabel.Text = "Fecha Nacimiento:";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.telefonoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLabel.Location = new System.Drawing.Point(21, 237);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(116, 26);
            this.telefonoLabel.TabIndex = 7;
            this.telefonoLabel.Text = "Telefono:";
            // 
            // fechNacDateTimePicker
            // 
            this.fechNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alumnosBindingSource, "FechNac", true));
            this.fechNacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechNacDateTimePicker.Location = new System.Drawing.Point(18, 194);
            this.fechNacDateTimePicker.Name = "fechNacDateTimePicker";
            this.fechNacDateTimePicker.Size = new System.Drawing.Size(144, 30);
            this.fechNacDateTimePicker.TabIndex = 6;
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(66, 20);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(262, 26);
            this.txBuscar.TabIndex = 21;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.txBuscar);
            this.panel2.Controls.Add(this.Bbuscar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 69);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Bbuscar
            // 
            this.Bbuscar.Image = global::InglesEscuela.Properties.Resources.buscar__1_;
            this.Bbuscar.Location = new System.Drawing.Point(334, 11);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(103, 45);
            this.Bbuscar.TabIndex = 22;
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InglesEscuela.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 35);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // conCalDataGridView
            // 
            this.conCalDataGridView.AllowUserToAddRows = false;
            this.conCalDataGridView.AllowUserToDeleteRows = false;
            this.conCalDataGridView.AutoGenerateColumns = false;
            this.conCalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conCalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.conCalDataGridView.DataSource = this.conCalBindingSource;
            this.conCalDataGridView.Location = new System.Drawing.Point(1, 655);
            this.conCalDataGridView.Name = "conCalDataGridView";
            this.conCalDataGridView.ReadOnly = true;
            this.conCalDataGridView.RowHeadersWidth = 62;
            this.conCalDataGridView.RowTemplate.Height = 28;
            this.conCalDataGridView.Size = new System.Drawing.Size(1045, 273);
            this.conCalDataGridView.TabIndex = 24;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreGrado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Grado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Calificación";
            this.dataGridViewTextBoxColumn5.HeaderText = "Calificación";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombrePro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Profesor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // conCalBindingSource
            // 
            this.conCalBindingSource.DataMember = "Alumnos_ConCal";
            this.conCalBindingSource.DataSource = this.alumnosBindingSource;
            // 
            // LbFoto
            // 
            this.LbFoto.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFoto.Location = new System.Drawing.Point(1017, 85);
            this.LbFoto.Name = "LbFoto";
            this.LbFoto.Size = new System.Drawing.Size(223, 138);
            this.LbFoto.TabIndex = 28;
            this.LbFoto.Text = "Foto No disponible";
            this.LbFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbFoto.Click += new System.EventHandler(this.label2_Click);
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
            // conCalTableAdapter
            // 
            this.conCalTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1099, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "Foto";
            // 
            // Bprint
            // 
            this.Bprint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bprint.Image = global::InglesEscuela.Properties.Resources.impresora;
            this.Bprint.Location = new System.Drawing.Point(1179, 520);
            this.Bprint.Name = "Bprint";
            this.Bprint.Size = new System.Drawing.Size(165, 115);
            this.Bprint.TabIndex = 31;
            this.Bprint.UseVisualStyleBackColor = true;
            this.Bprint.Click += new System.EventHandler(this.Bprint_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEliminar.Image = global::InglesEscuela.Properties.Resources.eliminar;
            this.BEliminar.Location = new System.Drawing.Point(999, 520);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(165, 115);
            this.BEliminar.TabIndex = 20;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Image = global::InglesEscuela.Properties.Resources.dc31;
            this.BGuardar.Location = new System.Drawing.Point(657, 520);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(165, 115);
            this.BGuardar.TabIndex = 16;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // BCancelar
            // 
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BCancelar.Enabled = false;
            this.BCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Image = global::InglesEscuela.Properties.Resources.archivo;
            this.BCancelar.Location = new System.Drawing.Point(486, 520);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(165, 115);
            this.BCancelar.TabIndex = 15;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // Bnuevo
            // 
            this.Bnuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnuevo.Image = global::InglesEscuela.Properties.Resources.papel;
            this.Bnuevo.Location = new System.Drawing.Point(828, 520);
            this.Bnuevo.Name = "Bnuevo";
            this.Bnuevo.Size = new System.Drawing.Size(165, 115);
            this.Bnuevo.TabIndex = 14;
            this.Bnuevo.UseVisualStyleBackColor = true;
            this.Bnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Foto
            // 
            this.Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Foto.Location = new System.Drawing.Point(997, 32);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(273, 239);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 29;
            this.Foto.TabStop = false;
            this.Foto.Click += new System.EventHandler(this.Foto_Click);
            // 
            // FAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1824, 998);
            this.Controls.Add(this.Bprint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbFoto);
            this.Controls.Add(this.conCalDataGridView);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.Bnuevo);
            this.Controls.Add(this.alumnosDataGridView);
            this.Controls.Add(this.alumnosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Foto);
            this.Name = "FAlumnos";
            this.Text = "Catalogo Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingNavigator)).EndInit();
            this.alumnosBindingNavigator.ResumeLayout(false);
            this.alumnosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conCalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                alumnosBindingSource.EndEdit();
                alumnosTableAdapter.Update(alumnosDBDataSet.Alumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Guardo / " + ex.Message, "A T E N C I O N");
            }
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            if (Completo())
            {
                try
                {
                    alumnosBindingSource.EndEdit();
                    alumnosTableAdapter.Update(alumnosDBDataSet.Alumnos);
                    DBlk();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Guardo / " + ex.Message, "A T E N C I O N");
                }
            }
            else
                MessageBox.Show("Registro Incompleto", " A T E N C I O N");
            DBlk();
        }

        // Fix for CS1525 and CS1002: The expression 'private' is invalid and a semicolon is expected.
        // Fix for SPELL: Renaming the method to a more appropriate name to avoid spelling issues.

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Implement the logic for saving here.
            // Example: Save changes to the database or perform other save-related actions.
        }


        #endregion

        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private AlumnosDBDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private AlumnosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView alumnosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Bnuevo;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BEliminar;
        private TextBox txBuscar;
        private Button Bbuscar;
        private PictureBox pictureBox1;
        private Panel panel2;
        private BindingSource conCalBindingSource;
        private AlumnosDBDataSetTableAdapters.ConCalTableAdapter conCalTableAdapter;
        private DataGridView conCalDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PictureBox Foto;
        private Label LbFoto;
        private Label LbProm;
        private TextBox idAlumnoTextBox;
        private Button Bprom;
        private Label LbId;
        private Label label1;
        private Label LbNombre;
        private TextBox nombreAluTextBox;
        private TextBox tutorTextBox;
        private Label tutorLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox telefonoTextBox;
        private Label fechNacLabel;
        private Label telefonoLabel;
        private DateTimePicker fechNacDateTimePicker;
        private Label label3;
        private Button Bprint;
        private ToolStripButton nuevoToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton guardarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton pegarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ayudaToolStripButton;
    }
}

