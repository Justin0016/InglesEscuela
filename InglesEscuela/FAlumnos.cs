using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace InglesEscuela
{
    public partial class FAlumnos : Form
    {
        public FAlumnos()
        {
            InitializeComponent();
            
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alumnosDBDataSet);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCal' Puede moverla o quitarla según sea necesario.
            this.conCalTableAdapter.Fill(this.alumnosDBDataSet.ConCal);
            CargaFoto();
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.alumnosDBDataSet.Alumnos);
            CargaFoto();
            Tips();
            

        }

        private void alumnosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaFoto();
        }

        private void alumnosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            CargaFoto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.AddNew();
            idAlumnoTextBox.Focus();
            Blk();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.CancelEdit();
            DBlk();
        }

        private void Blk()
        {
            BCancelar.Enabled = true;
            alumnosDataGridView.Enabled = false;
            alumnosBindingNavigator.Enabled = false;
            Bnuevo.Enabled = false;
            BEliminar.Enabled = false;
            panel2.Enabled = false;
            Bprom.Enabled = false;

        }

        private void DBlk()
        {
            BCancelar.Enabled = false;
            alumnosDataGridView.Enabled = true;
            alumnosBindingNavigator.Enabled = true;
            Bnuevo.Enabled = true;
            BEliminar.Enabled = true;
            panel2.Enabled = true;
            Bprom.Enabled = true;
        }

        private void Bguardar_Click1(object sender, EventArgs e)
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



        private void idAlumnoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (idAlumnoTextBox.Text == "")
                LbId.ForeColor = Color.Red;
            else
                LbId.ForeColor = Color.Black;
            CargaFoto();

        }


        private bool Completo()
        {
            if ((idAlumnoTextBox.Text != "") && (nombreAluTextBox.Text != ""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Faltan Datos", "A T E N C I O N");
                return false;
            }

        }




        private void nombreAluTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nombreAluTextBox.Text == "")
                LbNombre.ForeColor = Color.Red;
            else
                LbNombre.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {

            DialogResult OP = MessageBox.Show("¿Desea Eliminar el Registro?", "A T E N C I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (OP == DialogResult.Yes)
            {
                alumnosBindingSource.RemoveCurrent();
                alumnosTableAdapter.Update(alumnosDBDataSet.Alumnos);
                this.alumnosTableAdapter.Fill(this.alumnosDBDataSet.Alumnos);
                CargaFoto();
            }
        }

        private void Tips()
        {
            ToolTip Tps = new ToolTip();
            Tps.ShowAlways = true;

            Tps.SetToolTip(this.BGuardar, "Guardar Cambios");
            Tps.SetToolTip(this.BEliminar, "Eliminar Registro");
            Tps.SetToolTip(this.BCancelar, "Cancelar Cambios");
            Tps.SetToolTip(this.Bnuevo, "Nuevo Registro");
            Tps.SetToolTip(this.Bbuscar, "Buscar Registro");
            Tps.SetToolTip(this.Bprom, "Calcular Promedio");
            CargaFoto();

        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
          //  if (txBuscar.Text !="")
            
               // this.alumnosTableAdapter.FillByNum(this.alumnosDBDataSet.Alumnos,txBuscar.Text);
          //  else
              //  this.alumnosTableAdapter.Fill(alumnosDBDataSet.Alumnos);


        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text != "")

                this.alumnosTableAdapter.FillByNum(this.alumnosDBDataSet.Alumnos, txBuscar.Text);
            else
                this.alumnosTableAdapter.Fill(alumnosDBDataSet.Alumnos);
            CargaFoto();
        }

        private void Bprom_Click(object sender, EventArgs e)
        {
            int TC = 0; decimal C = 0;
            TC = conCalDataGridView.RowCount;
            if (conCalDataGridView.RowCount > 0)
            {
                for (int R = 0; R < TC; R++)
                {
                    C = C + Convert.ToDecimal(conCalDataGridView.Rows[R].Cells[2].Value);
                }
                LbProm.Text = (Convert.ToString(C / TC).Substring(0,3));
            }
            else 
                LbProm.Text = "0.0";
            CargaFoto();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LbProm.Text = "0.0";
            Foto.Image = null;
            CargaFoto();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            CargaFoto();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CargaFoto();
        }

        private void CargaFoto()
        {
            try
            {
                LbFoto.Visible = false;
                string rutaFoto = "C:\\Alumnos\\Fotos\\" + idAlumnoTextBox.Text + ".jpg";

                if (System.IO.File.Exists(rutaFoto))
                {
                    Foto.Image = Image.FromFile(rutaFoto);
                }
                else
                {
                    Foto.Image = null;
                    LbFoto.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la foto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Foto.Image = null;
            }
        }

        private void Foto_Click(object sender, EventArgs e)
        {
            CargaFoto();
        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bprint_Click(object sender, EventArgs e)
        {
            if (conCalDataGridView.RowCount > 0) 
            {
                CControl.IdAlu = idAlumnoTextBox.Text;
                CControl.NomAlu = nombreAluTextBox.Text;


                FRCalAlu Frm = new FRCalAlu();
                Frm.Show();

            }
               
        }
    }
    }






