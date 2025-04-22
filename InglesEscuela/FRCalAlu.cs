using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace InglesEscuela
{
    public partial class FRCalAlu : Form
    {
        public FRCalAlu()
        {
            InitializeComponent();
        }

        private void FRCalAlu_Load(object sender, EventArgs e)
        {
            
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PNomAlu", CControl.NomAlu);
            this.reportViewer1.LocalReport.SetParameters(parameters);


            // TODO: esta línea de código carga datos en la tabla 'alumnosDBDataSet.ConCalAlu' Puede moverla o quitarla según sea necesario.
            this.conCalAluTableAdapter.FillByIdAlu(this.alumnosDBDataSet.ConCalAlu,CControl.IdAlu);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
