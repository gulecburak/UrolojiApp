using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Functions;
using UrolojiApp.PrintingOperations;
namespace UrolojiApp.Models
{
    public partial class frmUrolojiList : Form
    {
        UrolojiDBDataContext dbC = new UrolojiDBDataContext();
        Formlar f = new Formlar();
        frmPrint frm;
        public frmUrolojiList()
        {
            InitializeComponent();
        }

        private void UrolojiList_Load(object sender, EventArgs e)
        {
            var list = dbC.UrolojiFulls.ToList();
            dataList.DataSource = list;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rdFullList.Checked)
            {
                if (frm == null || frm.IsDisposed)
                {
                    frm = new frmPrint();
                    frm.HangiListe = "UrolojiList";
                    frm.MdiParent = Application.OpenForms["frmMain"] as frmMain;
                    frm.Show();
                }
            }
            else if (rdPatientTrack.Checked)
            {
                if (frm == null || frm.IsDisposed)
                {
                    frm = new frmPrint();
                    frm.HangiListe = "PatientandTrackingList";
                    frm.MdiParent = Application.OpenForms["frmMain"] as frmMain;
                    frm.Show();
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdFullList_CheckedChanged(object sender, EventArgs e)
        {
            var list = dbC.UrolojiFulls.ToList();
            dataList.DataSource = list;
        }

        private void rdPatientTrack_CheckedChanged(object sender, EventArgs e)
        {
            var list = dbC.patientTrackingViews.ToList();
            dataList.DataSource = list;
        }
    }
}
