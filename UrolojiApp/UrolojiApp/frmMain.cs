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
namespace UrolojiApp
{
    public partial class frmMain : Form
    {
        Formlar f = new Formlar();

        public static string TransferS;
        public static int TransferI;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            grpLeft.Text = "Böbrek Giriş";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl2.Visible = true;
            pnl1.Visible = false;
            pnl3.Visible = false;
            grpLeft.Text = "Bilgi Giriş";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl3.Visible = true;
            pnl2.Visible = false;
            pnl1.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            f.PatientEntry();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            grpLeft.Text = "Böbrek Giriş";

        }

        private void btnOpType_Click(object sender, EventArgs e)
        {
            f.OperationType();
        }

        private void btnDr_Click(object sender, EventArgs e)
        {
            f.DrEntry();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            f.SubEntry();
        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            f.FindPatient();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            f.UrolojiList();
        }
    }
}
