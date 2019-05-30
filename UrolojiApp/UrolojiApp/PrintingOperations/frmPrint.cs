using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.PrintingOperations;
using UrolojiApp.Models;
using UrolojiApp.Functions;
namespace UrolojiApp.PrintingOperations
{
    public partial class frmPrint : Form
    {
        UrolojiDBDataContext dbc = new UrolojiDBDataContext();
        public string HangiListe;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            switch (HangiListe)
            {
                case "UrolojiList":
                    UrolojiList();
                    break;
                case "PatientandTrackingList":
                    UrolojiPatientTrack();
                    break;
                default:
                    break;
            }
        }

        private void UrolojiList()
        {
            frmUrolojiList lst = Application.OpenForms["frmUrolojiList"] as frmUrolojiList;
            urolojiList cr = new urolojiList();
            var list = dbc.UrolojiFulls.ToList();
            if (list!=null)
            {
                PrintHelp ch = new PrintHelp();//CH=Crystal Help
                DataTable dt = ch.ConvertTo(list);
                cr.SetDataSource(dt);
                crvList.ReportSource = cr;
            }

        }
        private void UrolojiPatientTrack()
        {
            frmUrolojiList lst = Application.OpenForms["frmUrolojiList"] as frmUrolojiList;
            PatientAndTrack cr = new PatientAndTrack();
            var list = dbc.patientTrackingViews.ToList();
            if (list != null)
            {
                PrintHelp ch = new PrintHelp();//CH=Crystal Help
                DataTable dt = ch.ConvertTo(list);
                cr.SetDataSource(dt);
                crvList.ReportSource = cr;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
