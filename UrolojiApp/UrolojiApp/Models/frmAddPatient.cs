using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrolojiApp.Functions;

namespace UrolojiApp.Models
{
    public partial class frmAddPatient : Form
    {
        #region instance
        UrolojiDBDataContext dbContext = new UrolojiDBDataContext();
        Messages m = new Messages();
        Formlar f = new Formlar();
        private bool _edit = false;
        int _patientId = -1;
        #endregion
        #region dllImport
        [DllImport("User32.dll")]
        #endregion

        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        public frmAddPatient()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GÖSTER";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnOpType = new Button();
            btnOpType.Size = new Size(25, txtOpType.ClientSize.Height + 2);
            btnOpType.Location = new Point(txtOpType.ClientSize.Width - btnOpType.Width, -1);
            btnOpType.Cursor = Cursors.Hand;
            txtOpType.Controls.Add(btnOpType);
            SendMessage(txtOpType.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnOpType.Width << 16));
            btnOpType.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnDr = new Button();
            btnDr.Size = new Size(25, txtDr.ClientSize.Height + 2);
            btnDr.Location = new Point(txtDr.ClientSize.Width - btnOpType.Width, -1);
            btnDr.Cursor = Cursors.Hand;
            txtDr.Controls.Add(btnDr);
            SendMessage(txtDr.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnDr.Width << 16));
            btnDr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnSub = new Button();
            btnSub.Size = new Size(25, txtSub.ClientSize.Height + 2);
            btnSub.Location = new Point(txtSub.ClientSize.Width - btnSub.Width, -1);
            btnSub.Cursor = Cursors.Hand;
            txtSub.Controls.Add(btnSub);
            SendMessage(txtSub.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnSub.Width << 16));
            btnSub.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnFind = new Button();
            btnFind.Size = new Size(25, txtPatientID.ClientSize.Height + 2);
            btnFind.Location = new Point(txtPatientID.ClientSize.Width - btnFind.Width, -1);
            btnFind.Cursor = Cursors.Hand;
            txtPatientID.Controls.Add(btnFind);
            SendMessage(txtPatientID.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnFind.Width << 16));
            btnFind.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);
            btnOpType.Click += btnOpType_Click;
            btnOpType.Text = "+";
            btnDr.Click += btnDr_Click;
            btnDr.Text = "+";
            btnSub.Click += btnSub_Click;
            btnSub.Text = "+";
            btnFind.Click += btnFind_Click;
            btnFind.Text = "+";

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = f.FindPatient(true);
            if (id > 0)
            {
                PatientOpen(id);
            }
            frmMain.TransferI = -1;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            f.SubEntry(true);
            if (!String.IsNullOrEmpty(frmMain.TransferS))
            {
                SubOpen();
            }
            else
            {
                MessageBox.Show("Aktarma veri boş kontrol edin");
            }
        }

        private void btnDr_Click(object sender, EventArgs e)
        {
            f.DrEntry(true);
            if (!String.IsNullOrEmpty(frmMain.TransferS))
            {
                DrOpen();
            }
            else
            {
                MessageBox.Show("Aktarma veri boş kontrol edin");
            }
        }

        private void btnOpType_Click(object sender, EventArgs e)
        {
            f.OperationType(true);
            if (!String.IsNullOrEmpty(frmMain.TransferS))
            {
                OpOpen();
            }
            else
            {
                MessageBox.Show("Aktarma veri boş kontrol edin");
            }
        }

        private void PatientOpen(int id)
        {
            _edit = true;
            _patientId = id;
            #region HastaBilgileri
            bHastaBilgileri hb = dbContext.bHastaBilgileris.First(x => x.ID == id);
            txtPatientID.Text = hb.ID.ToString();
            txtName.Text = hb.HastaAdı;
            txtSurname.Text = hb.HastaSoyadı;
            txtProtNo.Text = hb.ProtokolNo;
            dtOpDate.Value = hb.OperasyonTarihi.Value;
            txtOpType.Text = hb.OpTuru;
            txtMonthTracking.Text = hb.TakipAy.ToString();
            txtAnah.Text = hb.Anah.ToString();
            #endregion
            #region DemografikÖzellikler
            bDemografikOzellikler dm = dbContext.bDemografikOzelliklers.First(x => x.HastaID == id);
            txtAge.Text = dm.Yas.ToString();
            txtLength.Text = dm.Boy.ToString();
            txtWeight.Text = dm.Kilo.ToString();
            txtBMI.Text = dm.BMI.ToString();
            cmbAsa.Text = dm.ASA.ToString();
            txtDr.Text = dm.DrAdi;
            cmbGender.Text = dm.Cinsiyet;
            cmbSide.Text = dm.Taraf;
            txtLcl.Text = dm.Lokalizasyon;
            txtSize.Text = dm.Boyut;
            txtKoMor.Text = dm.KoMorbidite;

            #endregion
            #region OperatifÖzellikler
            bOperatifBilgiler ob = dbContext.bOperatifBilgilers.First(x => x.HastaID == id);
            cmbPks.Text = ob.PksAciklamasi;
            txtPlaint.Text = ob.Sikayet;
            txtCoop.Text = ob.CoOperasyon;
            txtSchme.Text = ob.Iskemi.ToString();
            txtPort.Text = ob.PortSayisi.ToString();
            txtHelp.Text = ob.YardimYNT;
            txtTime.Text = ob.Sure.ToString();
            txtDren.Text = ob.Dren;
            TxtBleed.Text = ob.Kanama.ToString();
            txtPiyes.Text = ob.Piyes.ToString();
            #endregion
            #region PosOperatifÖzellikler
            bPosOperatifOzellikler poo = dbContext.bPosOperatifOzelliklers.First(x => x.HastaID == id);
            cmbPreOpKomp.Text = poo.PreOpveErkenKomp;
            txtPostOpAnalysis.Text = poo.PostOpAnaliz;
            cmbSonda.Text = poo.Sonda;
            txtHosp.Text = poo.HospSuresi.ToString();
            txtPreOpKre.Text = poo.PreOpKreatin.ToString();
            txtPostOpKre.Text = poo.PostOpKreatin.ToString();
            txtPreOpHct.Text = poo.PreOpHCT.ToString();
            txtPostHct.Text = poo.PostOpHCT.ToString();
            txtPreOpHb.Text = poo.PreOpHB.ToString();
            txtPostOpHb.Text = poo.PostOpHB.ToString();
            txtTracking.Text = poo.Takip;
            txtTel.Text = poo.Tel;
            txtPostOpGKomp.Text = poo.PostOpGecKomp;
            txtKompClavien.Text = poo.KompClavien;

            #endregion
            #region PatolojikÖzellikler
            bPatolojikVeriler pv = dbContext.bPatolojikVerilers.First(x => x.HastaID == id);
            txtPatoloji.Text = pv.Patoloji;
            txtSub.Text = pv.AltGrup;
            cmbFuhrmanGrade.Text = pv.FuhrmanGrade;
            cmbPatolojikEvre.Text = pv.PatolojikEvreler;
            cmbCerrahiSinir.Text = pv.CerrahiSinir;

            #endregion
            #region TakipVerileri
            bTakipVerileri tv = dbContext.bTakipVerileris.First(x => x.HastaID == id);
            cmb3MonthNuks.Text = tv.PostOp3AyLokalNuks;
            txt3MonthKre.Text = tv.PostOp3AyKreatin.ToString();
            cmb6MonthNuks.Text = tv.PostOp6AyLokalNuks;
            txt6MonthKre.Text = tv.PostOp6AyKreatin.ToString();
            cmb12MonthNuks.Text = tv.PostOp12AyLokalNuks;
            txt12MonthKre.Text = tv.PostOp12AyKreatin.ToString();

            #endregion
        }

        void OpOpen()
        {
            txtOpType.Text = frmMain.TransferS;
            frmMain.TransferS = "";
        }

        void DrOpen()
        {
            txtDr.Text = frmMain.TransferS;
            frmMain.TransferS = "";
        }

        void SubOpen()
        {
            txtSub.Text = frmMain.TransferS;
            frmMain.TransferS = "";
        }

        void FlOpen()
        {
            txtTracking.Text = frmMain.TransferS;
            frmMain.TransferS = "";
        }

        void BMICalculate()
        {
            if (!string.IsNullOrEmpty(txtLength.Text) && !string.IsNullOrEmpty(txtWeight.Text))
            {
                decimal length, kg, bmi;
                length = decimal.Parse(txtLength.Text);
                kg = decimal.Parse(txtWeight.Text);
                //bmi = (kg / ((length * length) / 10000));
                //bmi = Math.Round(bmi, 2);
                bmi = Math.Round((kg / ((length * length) / 10000)), 2);
                txtBMI.Text = bmi.ToString();
            }
        }

        void UpdateRecord()
        {
            
            #region HastaBilgileri
            bHastaBilgileri hb = dbContext.bHastaBilgileris.First(x => x.ID == _patientId);
            {
                hb.HastaAdı = txtName.Text;
                hb.HastaSoyadı = txtSurname.Text;
                hb.ProtokolNo = txtProtNo.Text;
                hb.OperasyonTarihi = dtOpDate.Value;
                hb.OpTuru = txtOpType.Text;
                hb.TakipAy = int.Parse(txtMonthTracking.Text);
                hb.Anah = int.Parse(txtAnah.Text);
            }
            #endregion
            #region DemografikOzellikler
            bDemografikOzellikler dm = dbContext.bDemografikOzelliklers.First(x => x.HastaID == _patientId);
            {
                dm.ASA = cmbAsa.Text != "" ? int.Parse(cmbAsa.Text) : -1;
                dm.BMI = txtBMI.Text != "" ? decimal.Parse(txtBMI.Text) : -1;
                dm.Boy = txtLength.Text != "" ? int.Parse(txtLength.Text) : -1;
                dm.Boyut = txtSize.Text;
                dm.Cinsiyet = cmbGender.Text;
                dm.DrAdi = txtDr.Text;
                dm.Kilo = txtWeight.Text != "" ? decimal.Parse(txtWeight.Text) : -1;
                dm.Yas = txtAge.Text != "" ? int.Parse(txtAge.Text) : -1;
                dm.KoMorbidite = txtKoMor.Text;
                dm.Lokalizasyon = txtLcl.Text;
                dm.Taraf = cmbSide.Text;

            };
            #endregion
            #region OperatifBilgiler
            bOperatifBilgiler ob = dbContext.bOperatifBilgilers.First(x => x.HastaID == _patientId);
            {
                ob.CoOperasyon = txtCoop.Text;
                ob.Dren = txtDren.Text;
                ob.Iskemi = txtSchme.Text != "" ? int.Parse(txtSchme.Text) : -1;
                ob.Kanama = TxtBleed.Text != "" ? int.Parse(TxtBleed.Text) : 1;
                ob.Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1;
                ob.PksAciklamasi = cmbPks.Text;
                ob.PortSayisi = txtPort.Text != "" ? int.Parse(txtPort.Text) : -1;
                ob.Sikayet = txtPlaint.Text;
                ob.Sure = txtTime.Text != "" ? int.Parse(txtTime.Text) : -1;
                ob.YardimYNT = txtHelp.Text;

            };
            #endregion
            #region PosOperatifOzellikler
            bPosOperatifOzellikler poo = dbContext.bPosOperatifOzelliklers.First(x => x.HastaID == _patientId);
            {
                poo.HospSuresi = txtHosp.Text != "" ? int.Parse(txtHosp.Text) : -1;
                poo.KompClavien = txtKompClavien.Text;
                poo.PostOpAnaliz = txtPostOpAnalysis.Text;
                poo.PostOpGecKomp = txtPostOpGKomp.Text;
                poo.PostOpHB = txtPostOpHb.Text != "" ? decimal.Parse(txtPostOpHb.Text) : -1;
                poo.PostOpHCT = txtPostHct.Text != "" ? decimal.Parse(txtPostHct.Text) : -1;
                poo.PostOpKreatin = txtPostOpKre.Text != "" ? decimal.Parse(txtPostOpKre.Text) : -1;
                poo.PreOpHB = txtPreOpHb.Text != "" ? decimal.Parse(txtPreOpHb.Text) : -1;
                poo.PreOpHCT = txtPreOpHct.Text != "" ? decimal.Parse(txtPreOpHct.Text) : -1;
                poo.PreOpKreatin = txtPreOpKre.Text != "" ? decimal.Parse(txtPreOpKre.Text) : -1;
                poo.PreOpveErkenKomp = cmbPreOpKomp.Text;
                poo.Sonda = cmbSonda.Text;
                poo.Takip = txtTracking.Text;
                poo.Tel = txtTel.Text;

            };
            #endregion
            #region PatolojikVeriler
            bPatolojikVeriler pv = dbContext.bPatolojikVerilers.First(x => x.HastaID == _patientId);
            {
                pv.Patoloji = txtPatoloji.Text;
                pv.FuhrmanGrade = cmbFuhrmanGrade.Text;
                pv.AltGrup = txtSub.Text;
                pv.PatolojikEvreler = cmbPatolojikEvre.Text;
                pv.CerrahiSinir = cmbCerrahiSinir.Text;

            };
            #endregion
            #region Takip Verileri
            bTakipVerileri tv = dbContext.bTakipVerileris.First(x => x.HastaID == _patientId);
            {
                tv.PostOp3AyLokalNuks = cmb3MonthNuks.Text;
                tv.PostOp6AyLokalNuks = cmb6MonthNuks.Text;
                tv.PostOp12AyLokalNuks = cmb12MonthNuks.Text;
                tv.PostOp3AyKreatin = txt3MonthKre.Text != "" ? decimal.Parse(txt3MonthKre.Text) : -1;
                tv.PostOp6AyKreatin = txt6MonthKre.Text != "" ? decimal.Parse(txt6MonthKre.Text) : -1;
                tv.PostOp12AyKreatin = txt12MonthKre.Text != "" ? decimal.Parse(txt12MonthKre.Text) : -1;

            };
            #endregion
            dbContext.SubmitChanges();
            m.UpdateRecordMessage(true);
            ClearPanel(tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6);
        }

        void NewRecord()
        {
            //Instance da direk olarak değerleri verirsen breakpoint attığında direk nesneye koyuyor . Tüm nesneyi gezer. Tek tek bakamıyoruz.
            #region HastaBilgileri
            bHastaBilgileri hb = new bHastaBilgileri()
            {
                HastaAdı = txtName.Text,
                HastaSoyadı = txtSurname.Text,
                ProtokolNo = txtProtNo.Text,
                OperasyonTarihi = dtOpDate.Value,
                OpTuru = txtOpType.Text,
                TakipAy = int.Parse(txtMonthTracking.Text),
                Anah = int.Parse(txtAnah.Text)
            };
            dbContext.bHastaBilgileris.InsertOnSubmit(hb);
            dbContext.SubmitChanges();
            #endregion
            #region DemografikOzellikler
            bDemografikOzellikler dm = new bDemografikOzellikler()
            {
                ASA = cmbAsa.Text != "" ? int.Parse(cmbAsa.Text) : -1,
                BMI = txtBMI.Text != "" ? decimal.Parse(txtBMI.Text) : -1,
                Boy = txtLength.Text != "" ? int.Parse(txtLength.Text) : -1,
                Boyut = txtSize.Text,
                Cinsiyet = cmbGender.Text,
                DrAdi = txtDr.Text,
                Kilo = txtWeight.Text != "" ? decimal.Parse(txtWeight.Text) : -1,
                Yas = txtAge.Text != "" ? int.Parse(txtAge.Text) : -1,
                KoMorbidite = txtKoMor.Text,
                Lokalizasyon = txtLcl.Text,
                Taraf = cmbSide.Text,
                HastaID = hb.ID
            };
            #endregion
            #region OperatifBilgiler
            bOperatifBilgiler ob = new bOperatifBilgiler()
            {
                CoOperasyon = txtCoop.Text,
                Dren = txtDren.Text,
                Iskemi = txtSchme.Text != "" ? int.Parse(txtSchme.Text) : -1,
                Kanama = TxtBleed.Text != "" ? int.Parse(TxtBleed.Text) : 1,
                Piyes = txtPiyes.Text != "" ? int.Parse(txtPiyes.Text) : -1,
                PksAciklamasi = cmbPks.Text,
                PortSayisi = txtPort.Text != "" ? int.Parse(txtPort.Text) : -1,
                Sikayet = txtPlaint.Text,
                Sure = txtTime.Text != "" ? int.Parse(txtTime.Text) : -1,
                YardimYNT = txtHelp.Text,
                HastaID = hb.ID
            };
            #endregion
            #region PosOperatifOzellikler
            bPosOperatifOzellikler poo = new bPosOperatifOzellikler()
            {
                HospSuresi = txtHosp.Text != "" ? int.Parse(txtHosp.Text) : -1,
                KompClavien = txtKompClavien.Text,
                PostOpAnaliz = txtPostOpAnalysis.Text,
                PostOpGecKomp = txtPostOpGKomp.Text,
                PostOpHB = txtPostOpHb.Text != "" ? decimal.Parse(txtPostOpHb.Text) : -1,
                PostOpHCT = txtPostHct.Text != "" ? decimal.Parse(txtPostHct.Text) : -1,
                PostOpKreatin = txtPostOpKre.Text != "" ? decimal.Parse(txtPostOpKre.Text) : -1,
                PreOpHB = txtPreOpHb.Text != "" ? decimal.Parse(txtPreOpHb.Text) : -1,
                PreOpHCT = txtPreOpHct.Text != "" ? decimal.Parse(txtPreOpHct.Text) : -1,
                PreOpKreatin = txtPreOpKre.Text != "" ? decimal.Parse(txtPreOpKre.Text) : -1,
                PreOpveErkenKomp = cmbPreOpKomp.Text,
                Sonda = cmbSonda.Text,
                Takip = txtTracking.Text,
                Tel = txtTel.Text,
                HastaID = hb.ID
            };
            #endregion
            #region PatolojikVeriler
            bPatolojikVeriler pv = new bPatolojikVeriler()
            {
                Patoloji = txtPatoloji.Text,
                FuhrmanGrade = cmbFuhrmanGrade.Text,
                AltGrup = txtSub.Text,
                PatolojikEvreler = cmbPatolojikEvre.Text,
                CerrahiSinir = cmbCerrahiSinir.Text,
                HastaID = hb.ID
            };
            #endregion
            #region Takip Verileri
            bTakipVerileri tv = new bTakipVerileri()
            {
                PostOp3AyLokalNuks = cmb3MonthNuks.Text,
                PostOp6AyLokalNuks = cmb6MonthNuks.Text,
                PostOp12AyLokalNuks = cmb12MonthNuks.Text,
                PostOp3AyKreatin = txt3MonthKre.Text != "" ? decimal.Parse(txt3MonthKre.Text) : -1,
                PostOp6AyKreatin = txt6MonthKre.Text != "" ? decimal.Parse(txt6MonthKre.Text) : -1,
                PostOp12AyKreatin = txt12MonthKre.Text != "" ? decimal.Parse(txt12MonthKre.Text) : -1,
                HastaID = hb.ID
            };
            #endregion

            dbContext.bDemografikOzelliklers.InsertOnSubmit(dm);
            dbContext.bOperatifBilgilers.InsertOnSubmit(ob);
            dbContext.bPosOperatifOzelliklers.InsertOnSubmit(poo);
            dbContext.bPatolojikVerilers.InsertOnSubmit(pv);
            dbContext.bTakipVerileris.InsertOnSubmit(tv);
            dbContext.SubmitChanges();

            m.NewRecordMessage("Kayıt işlemi yapıldı.");
            ClearPanel(tabPage1,tabPage2,tabPage3,tabPage4,tabPage5,tabPage6);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_edit== true && _patientId>0 && m.UpdateRecordMessage()==DialogResult.Yes)
            {
                UpdateRecord();
            }
            else if(_edit==false)
            {
                NewRecord();
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            BMICalculate();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            BMICalculate();
        }

        void ClearPanel(params TabPage[] tb)
        {
            for (int i = 0; i < tb.Count(); i++)
            {
                foreach (Control ct in tb[i].Controls)
                {
                    if (ct is TextBox || ct is ComboBox)
                    {
                        ct.Text = "";
                    }
                    if(ct is DateTimePicker)
                    {
                        ct.Text=DateTime.Now.ToString();
                    }
                    
                }
            }
           
            _edit = false;
            _patientId = -1;
            frmMain.TransferI = -1;
            frmMain.TransferS = "";
        }

        private void txtMonthTracking_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMonthTracking_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Bu kod geliştirilecek.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(".")>-1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(",") > -1)
            {
                e.Handled = true;
            }
        }

        private void txtAnah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtProtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtMonthTracking_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
