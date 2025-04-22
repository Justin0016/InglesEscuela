namespace InglesEscuela
{
    partial class FLogin1
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
            System.Windows.Forms.Label idUserLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label nombreUsrLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nivelUsrLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.TxPass = new System.Windows.Forms.TextBox();
            this.TxUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbVer = new System.Windows.Forms.Label();
            this.idUserTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsrTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nivelUsrTextBox = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosDBDataSet = new InglesEscuela.AlumnosDBDataSet();
            this.usuariosTableAdapter = new InglesEscuela.AlumnosDBDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idUserLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            nombreUsrLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nivelUsrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // TxPass
            // 
            this.TxPass.Location = new System.Drawing.Point(325, 486);
            this.TxPass.Name = "TxPass";
            this.TxPass.PasswordChar = '*';
            this.TxPass.Size = new System.Drawing.Size(166, 26);
            this.TxPass.TabIndex = 1;
            // 
            // TxUser
            // 
            this.TxUser.Location = new System.Drawing.Point(326, 399);
            this.TxUser.Name = "TxUser";
            this.TxUser.Size = new System.Drawing.Size(165, 26);
            this.TxUser.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(326, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbVer
            // 
            this.LbVer.AutoSize = true;
            this.LbVer.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbVer.Location = new System.Drawing.Point(497, 486);
            this.LbVer.Name = "LbVer";
            this.LbVer.Size = new System.Drawing.Size(53, 29);
            this.LbVer.TabIndex = 8;
            this.LbVer.Text = "(o)";
            this.LbVer.Click += new System.EventHandler(this.LbVer_Click);
            // 
            // idUserLabel
            // 
            idUserLabel.AutoSize = true;
            idUserLabel.Location = new System.Drawing.Point(304, 112);
            idUserLabel.Name = "idUserLabel";
            idUserLabel.Size = new System.Drawing.Size(65, 20);
            idUserLabel.TabIndex = 10;
            idUserLabel.Text = "Id User:";
            // 
            // idUserTextBox
            // 
            this.idUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUser", true));
            this.idUserTextBox.Location = new System.Drawing.Point(408, 112);
            this.idUserTextBox.Name = "idUserTextBox";
            this.idUserTextBox.Size = new System.Drawing.Size(100, 26);
            this.idUserTextBox.TabIndex = 11;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(304, 144);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(68, 20);
            usuarioLabel.TabIndex = 12;
            usuarioLabel.Text = "Usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(408, 144);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 26);
            this.usuarioTextBox.TabIndex = 13;
            // 
            // nombreUsrLabel
            // 
            nombreUsrLabel.AutoSize = true;
            nombreUsrLabel.Location = new System.Drawing.Point(304, 179);
            nombreUsrLabel.Name = "nombreUsrLabel";
            nombreUsrLabel.Size = new System.Drawing.Size(98, 20);
            nombreUsrLabel.TabIndex = 14;
            nombreUsrLabel.Text = "Nombre Usr:";
            // 
            // nombreUsrTextBox
            // 
            this.nombreUsrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "NombreUsr", true));
            this.nombreUsrTextBox.Location = new System.Drawing.Point(408, 176);
            this.nombreUsrTextBox.Name = "nombreUsrTextBox";
            this.nombreUsrTextBox.Size = new System.Drawing.Size(100, 26);
            this.nombreUsrTextBox.TabIndex = 15;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(304, 211);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 16;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(408, 208);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordTextBox.TabIndex = 17;
            // 
            // nivelUsrLabel
            // 
            nivelUsrLabel.AutoSize = true;
            nivelUsrLabel.Location = new System.Drawing.Point(304, 243);
            nivelUsrLabel.Name = "nivelUsrLabel";
            nivelUsrLabel.Size = new System.Drawing.Size(75, 20);
            nivelUsrLabel.TabIndex = 18;
            nivelUsrLabel.Text = "Nivel Usr:";
            // 
            // nivelUsrTextBox
            // 
            this.nivelUsrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "NivelUsr", true));
            this.nivelUsrTextBox.Location = new System.Drawing.Point(408, 240);
            this.nivelUsrTextBox.Name = "nivelUsrTextBox";
            this.nivelUsrTextBox.Size = new System.Drawing.Size(100, 26);
            this.nivelUsrTextBox.TabIndex = 19;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.alumnosDBDataSet;
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalificacionesTableAdapter = null;
            this.tableAdapterManager.GradoTableAdapter = null;
            this.tableAdapterManager.ProfesoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = InglesEscuela.AlumnosDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InglesEscuela.Properties.Resources.perfil_del_usuario__1_;
            this.pictureBox2.Location = new System.Drawing.Point(215, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 304);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::InglesEscuela.Properties.Resources.usuario__1_;
            this.pictureBox3.Location = new System.Drawing.Point(249, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InglesEscuela.Properties.Resources.bloqueado;
            this.pictureBox1.Location = new System.Drawing.Point(255, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbVer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxUser);
            this.Controls.Add(this.TxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(idUserLabel);
            this.Controls.Add(this.idUserTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(nombreUsrLabel);
            this.Controls.Add(this.nombreUsrTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(nivelUsrLabel);
            this.Controls.Add(this.nivelUsrTextBox);
            this.Name = "FLogin1";
            this.Load += new System.EventHandler(this.FLogin1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxPass;
        private System.Windows.Forms.TextBox TxUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbVer;
        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private AlumnosDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private AlumnosDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idUserTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox nombreUsrTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nivelUsrTextBox;
        private System.Windows.Forms.Label label3;
    }
}