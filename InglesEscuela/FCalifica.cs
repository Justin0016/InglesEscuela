using System;
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
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.alumnosDBDataSet.Calificaciones);
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCalGen' Puede moverla o quitarla según sea necesario.
            this.conCalGenTableAdapter.Fill(this.alumnosDBDataSet.ConCalGen);
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
                        calificacionesDataGridView.Rows[R].Cells[2].Value = conCalGenDataGridView.Rows[R].Cells[1].Value;
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
            this.conCalGenTableAdapter.Fill(this.alumnosDBDataSet.ConCalGen);
            CarNom();

        }

        private void calificacionesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ren = e.RowIndex;

            if (calificacionesDataGridView.Rows[ren].Cells[0].Value == DBNull.Value ||
                string.IsNullOrEmpty(Convert.ToString(calificacionesDataGridView.Rows[ren].Cells[0].Value)))
            {
                calificacionesDataGridView.Rows[ren].Cells[0].Value = DateTime.Now; // Example value
            }
        }
    }


}
