using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InglesEscuela
{
    public partial class FLogin1 : Form
    {
        public FLogin1()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alumnosDBDataSet);

        }

        private void FLogin1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.alumnosDBDataSet.Usuarios);

        }

        private void LbVer_Click(object sender, EventArgs e)
        {
         if (TxPass.PasswordChar == '*')
            {
                TxPass.PasswordChar = '\0';
                
            }
            else
            {
                TxPass.PasswordChar = '*';
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxUser.Text != "" && TxPass.Text != "")
            {
                this.usuariosTableAdapter.FillByID(this.alumnosDBDataSet.Usuarios, TxUser.Text);
                if (TxPass.Text == passwordTextBox.Text)
                {
                    CControl.IdUser = idUserTextBox.Text;
                    CControl.User = usuarioTextBox.Text;
                    CControl.NivUsr = nivelUsrTextBox.Text;
                    TxPass.Text = "";
                    TxUser.Text = "";

                    FMenu Frm = new FMenu();
                    this.Hide();
                    DialogResult dialogResult = Frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña o usuario incorrecto", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

