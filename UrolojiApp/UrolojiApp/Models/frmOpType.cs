using System;
using System.Collections;
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
    public partial class frmOpType : Form
    {
        public frmOpType()
        {
            InitializeComponent();
        }
        UrolojiDBDataContext dbC = new UrolojiDBDataContext();
        Messages m = new Messages();
        public bool Secim;
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            NewRecordOpType();
        }
        private void frmOpType_Load(object sender, EventArgs e)
        {

            BringOpTypeList();

        }
        void BringOpTypeList()
        {
            chcLstOpType.Items.Clear();
            var opTypeList = dbC.bOpTurus.Distinct().OrderByDescending(x => x.Id).ToList();
            //for (int i = 0; i < opTypeList.Count; i++)
            //{
            //    chcLstOpType.Items.Add(opTypeList[i].OpName);
            //}
            foreach (var j in opTypeList)
            {
                chcLstOpType.Items.Add(j.OpName);
            }

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Join methodunda ilk önce ayıracı belirtiyoruz.Sonra gelecek elemanları gösteriyoruz.
            //OfType<> içinde belirttiğimiz tip o tipte arıyor.
            frmMain.TransferS = string.Join("+", chcLstOpType.CheckedItems.OfType<String>().ToList());
            Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < chcLstOpType.CheckedItems.Count; i++)
                {
                    dbC.bOpTurus.DeleteOnSubmit(dbC.bOpTurus.First(x => x.OpName == chcLstOpType.CheckedItems[i].ToString()));
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
        void NewRecordOpType()
        {
            try
            {
                bOpTuru opType = new bOpTuru() { OpName = txtOpType.Text };
                dbC.bOpTurus.InsertOnSubmit(opType);
                dbC.SubmitChanges();
                //m.NewRecordMessage("Kayıt tamamlandı.");
                txtOpType.Clear();
                BringOpTypeList();
            }
            catch (Exception ex)
            {
                m.ErrorMessage(ex);
            }
        }
        
    }
}
