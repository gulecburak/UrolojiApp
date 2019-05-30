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
    public partial class frmDr : Form
    {
        UrolojiDBDataContext dbC = new UrolojiDBDataContext();
        Messages m = new Messages();
        public bool Secim;
        public frmDr()
        {
            InitializeComponent();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            NewRecordDr();
        }
       
        void BringOpTypeList()
        {
            chcLstDr.Items.Clear();
            var drList = dbC.bDoctors.Distinct().OrderByDescending(x => x.Id).ToList();
            //for (int i = 0; i < opTypeList.Count; i++)
            //{
            //    chcLstOpType.Items.Add(opTypeList[i].OpName);
            //}
            foreach (var j in drList)
            {
                chcLstDr.Items.Add(j.DrName);
            }

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Join methodunda ilk önce ayıracı belirtiyoruz.Sonra gelecek elemanları gösteriyoruz.
            //OfType<> içinde belirttiğimiz tip o tipte arıyor.
            frmMain.TransferS = string.Join("+", chcLstDr.CheckedItems.OfType<String>().ToList());
            Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < chcLstDr.CheckedItems.Count; i++)
                {
                    dbC.bDoctors.DeleteOnSubmit(dbC.bDoctors.First(x => x.DrName == chcLstDr.CheckedItems[i].ToString()));
                }
                dbC.SubmitChanges();
                BringOpTypeList();
            }
            catch (Exception ex)
            {
                m.ErrorMessage(ex);
            }
        }
        //Ctrl+K+S kullanarak toplu şekilde işlem yapabiliriz.
        void NewRecordDr()
        {
            try
            {
                bDoctor dr = new bDoctor() { DrName = txtAddDr.Text };
                dbC.bDoctors.InsertOnSubmit(dr);
                dbC.SubmitChanges();
                //m.NewRecordMessage("Kayıt tamamlandı.");
                txtAddDr.Clear();
                BringOpTypeList();
            }
            catch (Exception ex)
            {
                m.ErrorMessage(ex);
            }
        }

        private void frmDr_Load(object sender, EventArgs e)
        {
            BringOpTypeList();

        }
    }
}
