using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Models;
namespace UrolojiApp.Functions
{
    class Formlar
    {
        frmAddPatient frm;
        public frmFindPatient frmFind;
        frmOpType frmOp;
        frmDr frmDr;
        frmSub frmSub;
        frmUrolojiList frmUro;
        public void PatientEntry()
        {

            if (frm == null || frm.IsDisposed)
            {
                frm = new frmAddPatient();
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        public void UrolojiList()
        {
            if (frmUro==null || frmUro.IsDisposed)
            {
                frmUro = new frmUrolojiList();
                frmUro.MdiParent = Form.ActiveForm;
                frmUro.WindowState = FormWindowState.Maximized;
                frmUro.Show();
            }
        }
        public int FindPatient(bool secim = false)
        {


            
            if (secim == true)
            {
                frmFind = new frmFindPatient();
                frmFind.Secim = true;

                frmFind.ShowDialog();

            }
            else
            {
                if (frmFind == null || frmFind.IsDisposed)
                {
                    frmFind = new frmFindPatient();
                    frmFind.MdiParent = Form.ActiveForm;
                    frmFind.Show();
                }
               
                //frmFind.btnTransfer.Enabled = false;
            }

            return frmMain.TransferI;
        }
        public void OperationType(bool secim = false)
        {


            if (secim == true)
            {
                frmOp = new frmOpType();
                frmOp.Secim = true;
                frmOp.ShowDialog();
                frmOp.btnTransfer.Enabled = true;
            }
            else
            {
                if (frmOp == null || frmOp.IsDisposed)
                {
                    frmOp = new frmOpType();
                    frmOp.MdiParent = Form.ActiveForm;
                    frmOp.Show();
                    frmOp.btnTransfer.Enabled = false;
                }
            }



        }
        public void DrEntry(bool secim = false)
        {
            if (secim == true)
            {
                frmDr = new frmDr();
                frmDr.Secim = true;
                frmDr.ShowDialog();
                frmDr.btnTransfer.Enabled = true;
            }
            else
            {
                if (frmDr == null || frmDr.IsDisposed)
                {
                    frmDr = new frmDr();
                    frmDr.MdiParent = Form.ActiveForm;
                    frmDr.Show();
                    frmDr.btnTransfer.Enabled = false;
                }
            }
        }
        public void SubEntry(bool secim = false)
        {
            
            if (secim == true)
            {
                frmSub = new frmSub();
                frmSub.Secim = true;
                frmSub.ShowDialog();
                frmSub.btnTransfer.Enabled = true;
            }
            else
            {
                if (frmSub == null || frmSub.IsDisposed)
                {
                    frmSub = new frmSub();
                    frmSub.MdiParent = Form.ActiveForm;
                    frmSub.Show();
                    frmSub.btnTransfer.Enabled = false;
                }
            }
        }

    }
}
