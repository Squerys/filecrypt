using System.Text;
using System.Security.Cryptography;

namespace FileCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (algorithm.Text == "MD5 (Encrypt Only)")
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(RawTextOrHash.Text));
                byte[] result = md5.Hash;
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    strBuilder.Append(result[i].ToString("x2"));
                }
                string message = "MD5 Encrypted Hash : " + strBuilder.ToString();
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result1;
                result1 = MessageBox.Show(message, caption, buttons, icon);
                RawTextOrHash.Text = strBuilder.ToString();
                RawTextOrHashLabel.Text = "Your Hashed Text : ";
            }

            if (algorithm.Text == "AES256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);

            }

            if (algorithm.Text == "SHA256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (algorithm.Text == "MD5 (Encrypt Only)")
            {
                string message = "Sorry, MD5 does not support decrypt";
                string caption = "MD5";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }

            if (algorithm.Text == "AES256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);

            }

            if (algorithm.Text == "SHA256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private void algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithm.Text == "AES256")
            {
                key.Show();
                KeyLabel.Show();
            }

            else
            {
                key.Hide();
                KeyLabel.Hide();
            }
        }
    }
}