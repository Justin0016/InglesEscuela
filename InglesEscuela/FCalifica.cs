using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InglesEscuela
{
    public partial class FCalifica : Form
    {
        private object Datetime;

        public FCalifica()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alumnosDBDataSet);

        }

        private void FCalifica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.alumnosDBDataSet.Profesores);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.alumnosDBDataSet.Alumnos);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCal' Puede moverla o quitarla según sea necesario.
            this.conCalTableAdapter.Fill(this.alumnosDBDataSet.ConCal);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCalAlu' Puede moverla o quitarla según sea necesario.
            this.conCalAluTableAdapter.Fill(this.alumnosDBDataSet.ConCalAlu);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCalGen' Puede moverla o quitarla según sea necesario.
            this.conCalGenTableAdapter.Fill(this.alumnosDBDataSet.ConCalGen);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.alumnosDBDataSet.Calificaciones);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.alumnosDBDataSet.Calificaciones);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCalGen' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.alumnosDBDataSet.Alumnos);

        }

        private void CarNom()
        {
            if (TapC1.SelectedIndex == 1) // Cambiado de "SelectIndex" a "SelectedIndex"
            {
                int TC = 0;
                TC = conCalGenDataGridView.RowCount;

                if (conCalGenDataGridView.RowCount > 0)
                {

                    for (int R = 0; R < TC; R++)
                    {
                        calificacionesDataGridView.Rows[R].Cells[5].Value = conCalGenDataGridView.Rows[R].Cells[3].Value;

                    }

                }
            }
        }





        private void TapC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarNom();
        }

        private void Blk(object tAPCon2)
        {
            calificacionesDataGridView.Enabled = true;
            Bedit.Enabled = false;
            Bsave.Enabled = true;
            Bcancel.Enabled = true;
            TP1.Parent = null;
        }

        private void DBlk(object tAPCon2)
        {
            calificacionesDataGridView.Enabled = false;
            Bedit.Enabled = true;
            Bsave.Enabled = false;
            Bcancel.Enabled = false;
            TapC1.TabPages.Insert(0, TP1);
        }

        private void Bedit_Click(object sender, EventArgs e)
        {
            
            Blk(TapC1);

        }

        private void Bcancel_Click(object sender, EventArgs e)
        {
           
            DBlk(TapC1);
           this.calificacionesTableAdapter.Fill(this.alumnosDBDataSet.Calificaciones);
            CarNom();

        }

     

        private void calificacionesDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int col = e.ColumnIndex;
            int ren = e.RowIndex;

            // Verificar que el índice de la fila es válido
            if (ren < 0 || ren >= calificacionesDataGridView.Rows.Count)
                return;

            calificacionesDataGridView.Rows[ren].ErrorText = "";

            // Validar columna de fecha
            if (col == 0)
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out DateTime fecha))
                {
                    e.Cancel = true;
                    calificacionesDataGridView.Rows[ren].ErrorText = "La fecha no es válida";
                }
            }

            // Validar columna de calificación
            if (col == 3)
            {
                if (!float.TryParse(e.FormattedValue.ToString(), out float number) || number > 10 || number < 5)
                {
                    e.Cancel = true;
                    calificacionesDataGridView.Rows[ren].ErrorText = "La calificación no es válida";
                }
            }
        }

        private void calificacionesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ren = e.RowIndex;

            // Verificar que el índice de la fila es válido
            if (ren < 0 || ren >= calificacionesDataGridView.Rows.Count)
                return;

            // Obtener el valor de la celda y verificar si está vacío
            var cellValue = calificacionesDataGridView.Rows[ren].Cells[1].Value;
            if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
            {
                // Asignar la fecha actual y el IdUser
                calificacionesDataGridView.Rows[ren].Cells[0].Value = DateTime.Now.Date;
                calificacionesDataGridView.Rows[ren].Cells[0].Value = CControl.IdUser; // Asegúrate de que la columna 2 sea la correcta para IdUser
            }
        }

        private void calificacionesDataGridView_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int col = e.ColumnIndex;
            int ren = e.RowIndex;
            // Verificar que el índice de la fila es válido
            if (ren < 0 || ren >= calificacionesDataGridView.Rows.Count)
                return;
            calificacionesDataGridView.Rows[ren].ErrorText = "";
            // Validar columna de fecha
            if (col == 0)
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out DateTime fecha))
                {
                    e.Cancel = true;
                    calificacionesDataGridView.Rows[ren].ErrorText = "La fecha no es válida";
                }
            }
            // Validar columna de calificación
            if (col == 4)
            {
                if (!float.TryParse(e.FormattedValue.ToString(), out float number) || number > 10 || number < 5)
                {
                    e.Cancel = true;
                    calificacionesDataGridView.Rows[ren].ErrorText = "La calificación no es válida";
                }
            }

        }

        private void calificacionesDataGridView_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Control Ctrl = e.Control;
            if (Ctrl is TextBox)
            {
                Ctrl.KeyPress += new KeyPressEventHandler(calificacionesDataGridView_KeyPress_1);

            }
        }

        private void calificacionesDataGridView_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            int col = calificacionesDataGridView.CurrentCell.ColumnIndex;
            if (col == 4)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
            }
        }

        private bool BusInc(int R)
        {
            int Tcol = calificacionesDataGridView.Columns.Count;
            for (int C = 0; C < Tcol; C++)
            {
                if (Convert.ToString(calificacionesDataGridView.Rows[R].Cells[C].Value) == "")
                {
                    return true;
                }
            }
            return false;
        }
         

    
      
private void Bsave_Click(object sender, EventArgs e)
        {
            int Tcal = calificacionesDataGridView.RowCount - 1;

            // Validar que no haya filas con celdas vacías  
            for (int R = 0; R < Tcal; R++)
            {
                if (BusInc(R))
                {
                    MessageBox.Show("Existen filas con campos vacíos. Por favor, complételos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                this.Validate();
                this.calificacionesBindingSource.EndEdit();

                // Verificar si hay cambios pendientes antes de actualizar  
                if (this.alumnosDBDataSet.HasChanges())
                {
                    this.tableAdapterManager.UpdateAll(this.alumnosDBDataSet);
                    MessageBox.Show("Los datos se han guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DBlk(TapC1);
                this.calificacionesTableAdapter.Fill(this.alumnosDBDataSet.Calificaciones);
                CarNom();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}














