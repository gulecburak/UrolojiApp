using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UrolojiApp.Functions
{
    class Messages
    {
        //@ işareti ne iş yapar?
        public void NewRecordMessage(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult UpdateRecordMessage()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir.\n Güncelleme işlemini onaylıyormusunuz?","Güncelleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult RecordMessage()
        {
            return MessageBox.Show("Aynı kaydı tekrar kaydetmek istiyormusunuz?","Kayıt Uyarısı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult DeleteRecordMessage()
        {
            return MessageBox.Show("Tüm kayıtlar kalıcı olarak silenecektir.\n Onaylıyormusunuz?","Kayıt Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public void UpdateRecordMessage(bool update)
        {
            MessageBox.Show("Kayıt güncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void ErrorMessage(Exception error)
        {
            MessageBox.Show(error.Message,"Hata oluştu.",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public DialogResult PrintRecords()
        {
            return MessageBox.Show("Kaydı yazdırmak istiyormusunuz","Yazdırma İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

    }
}
