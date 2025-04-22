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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmOpen = Application.OpenForms["FAlumnos"];

            if (FrmOpen == null)
            { 

            FAlumnos Frm = new FAlumnos();
            Frm.MdiParent = this;
            Frm.Show();
            }
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOpen = Application.OpenForms["Grado"];
            if (frmOpen == null)
            {
                Grado Frm = new Grado();
                Frm.MdiParent = this;
                Frm.Show();
            }

        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOpen = Application.OpenForms["FCalificar"];
            if (frmOpen == null)
            {
                FCalificacionesV frm = new FCalificacionesV();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Form frmOpen = Application.OpenForms["FInformes"];
            if (frmOpen == null)
            {
                FInformes frm = new FInformes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void utileriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOpen = Application.OpenForms["FUtileria"];
            if (frmOpen == null)
            {
                FUtileria frm = new FUtileria();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formOpen = Application.OpenForms["FCalifica"];
            if (formOpen == null)
            {
                FCalifica form = new FCalifica();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
