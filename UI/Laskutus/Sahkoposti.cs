using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace VillageNewbies.UI
{
    public partial class Sahkoposti : Form
    {
        OpenFileDialog fileDialog;
        string filename;
        public Sahkoposti()
        {
            InitializeComponent();
        }

        private void Btn_Selaa_Click(object sender, EventArgs e)
        {
            try
            {
                fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Images(.jpg, .png|*.png; *.jpg;|Pdf files|*.pdf";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = fileDialog.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Laheta_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient(comboBox_SMTP.SelectedItem.ToString());
                client.Port = 587;
                client.Credentials = new NetworkCredential(Textbox_LahettajaEmail.Text, textBox_LahettajaSalasana.Text);
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Textbox_LahettajaEmail.Text);
                mail.To.Add(textBox_VastOttajanEmail.Text);
                mail.Subject = textBox_Aihe.Text;
                mail.Body = richTextBox_Viesti.Text.Trim();

                if (filename.Length > 0)
                {
                    Attachment attachment = new Attachment(filename);
                    mail.Attachments.Add(attachment);
                }
                client.Send(mail);
                MessageBox.Show("Viesti lähetetty");
                filename = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
