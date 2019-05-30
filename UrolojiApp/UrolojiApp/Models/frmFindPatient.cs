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
namespace UrolojiApp.Models
{
    public partial class frmFindPatient : Form
    {
        UrolojiDBDataContext dbC = new UrolojiDBDataContext();
        public bool Secim;
        int secimID = -1;
        public frmFindPatient()
        {
            InitializeComponent();
        }

        private void frmFindPatient_Load(object sender, EventArgs e)
        {
            AllList();
        }

        private void ListPatient()
        {
            if (rdName.Checked)
            {

                var findByName = (from s in dbC.bHastaBilgileris
                                  where s.HastaAdı.Contains(txtHastaAdi.Text)
                                  select new { s.ID, s.ProtokolNo, s.HastaAdı, s.HastaSoyadı, s.OperasyonTarihi }).ToList();
                
                dataListPatient.DataSource = findByName;
                
            }
            else if(rdProt.Checked)
            {
                var findByProtNo = (from s in dbC.bHastaBilgileris
                                  where s.ProtokolNo==txtProtNo.Text
                                  select new { s.ID, s.ProtokolNo, s.HastaAdı, s.HastaSoyadı, s.OperasyonTarihi }).ToList();
                
                dataListPatient.DataSource = findByProtNo;
                
            }
            txtProtNo.Text = "";
            txtHastaAdi.Text = "";
            //dataListPatient.Rows.Clear();
            //foreach (var k in findByName)
            //{
            //    dataListPatient.Rows.Add();
            //    dataListPatient.Rows[i].Cells[0].Value = k.ID;
            //    dataListPatient.Rows[i].Cells[1].Value = k.ProtokolNo;
            //    dataListPatient.Rows[i].Cells[2].Value = k.HastaAdı;
            //    dataListPatient.Rows[i].Cells[3].Value = k.HastaSoyadı;
            //    dataListPatient.Rows[i].Cells[4].Value = k.OperasyonTarihi;
            //    i++;
            //}
            //dataListPatient.AllowUserToAddRows=false;
            //dataListPatient.AllowUserToDeleteRows = false;

            ////var findByProtNo= (from s in dbC.bHastaBilgileris
            ////                   where s.ProtokolNo==
            ////                   select s).ToList();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ListPatient();

        }

        private void txtHastaAdi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        void SelectPatient()
        {
            try
            {
                secimID = int.Parse(dataListPatient.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                secimID = -1;
            }
    

        }
        private void dataListPatient_DoubleClick(object sender, EventArgs e)
        {
            SelectPatient();
            if (secimID>0)
            {
                frmMain.TransferI = secimID;
                Close();
            }
        }

        private void rdProt_CheckedChanged(object sender, EventArgs e)
        {
            txtHastaAdi.Enabled = false;
            txtProtNo.Enabled = true;
            txtProtNo.Text = "";
        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {
            txtProtNo.Enabled = false;
            txtHastaAdi.Enabled = true;
            txtHastaAdi.Text = "";
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            AllList();
        }
        void AllList()
        {
            dataListPatient.DataSource = dbC.bHastaBilgileris.Select(x => new { x.ID, x.ProtokolNo, x.HastaAdı, x.HastaSoyadı, x.OperasyonTarihi }).ToList();
        }
    }
}
