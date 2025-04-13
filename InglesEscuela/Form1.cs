using System;
using System.Windows.Forms;

namespace InglesEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
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
            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.alumnosDBDataSet.Alumnos);

        }



    }
}
