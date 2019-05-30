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
    public partial class frmSub : Form
    {
        public frmSub()
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
        private void frmSub_Load(object sender, EventArgs e)
        {

            BringOpTypeList();

        }
        void BringOpTypeList()
        {
            chcSub.Items.Clear();
            var sub = dbC.bAltgrups.Distinct().OrderByDescending(x => x.Id).ToList();
            //for (int i = 0; i < opTypeList.Count; i++)
            //{
            //    chcLstOpType.Items.Add(opTypeList[i].OpName);
            //}
            foreach (var j in sub)
            {
                chcSub.Items.Add(j.Altgrup);
            }

        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Join methodunda ilk önce ayıracı belirtiyoruz.Sonra gelecek elemanları gösteriyoruz.
            //OfType<> içinde belirttiğimiz tip o tipte arıyor.
            frmMain.TransferS = string.Join("+", chcSub.CheckedItems.OfType<String>().ToList());
            Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < chcSub.CheckedItems.Count; i++)
                {
                    dbC.bAltgrups.DeleteOnSubmit(dbC.bAltgrups.First(x => x.Altgrup == chcSub.CheckedItems[i].ToString()));
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
                bAltgrup sub = new bAltgrup() { Altgrup = txtSub.Text };
                dbC.bAltgrups.InsertOnSubmit(sub);
                dbC.SubmitChanges();
                //m.NewRecordMessage("Kayıt tamamlandı.");
                txtSub.Clear();
                BringOpTypeList();
            }
            catch (Exception ex)
            {
                m.ErrorMessage(ex);
            }
        }

    }
}
