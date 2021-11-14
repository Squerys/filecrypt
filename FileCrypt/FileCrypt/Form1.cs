using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

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
            if (algorithm.Text == "File Version")
            {
                File.Encrypt(FilePathTextBox.Text);
                string message = "File encrypted : " + FilePathTextBox.Text + "\n You are now the only account on this computer allowed to decrypt it";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }

            if (algorithm.Text == "Base64")
            {
                RawTextOrHash.Text = Base64Encode(RawTextOrHash.Text);
                RawTextOrHashLabel.Text = "Hashed Text";
                string message = "Your  Base64 hashed text is : " + RawTextOrHash.Text;
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
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
                RawTextOrHashLabel.Text = "Your MD5 Hashed Text : ";
            }

            if (algorithm.Text == "AES-256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);

            }

            if (algorithm.Text == "SHA-256")
            {
                static string ComputeSha256Hash(string rawData)
                {
                    // Create a SHA256   
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        // ComputeHash - returns byte array  
                        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                        // Convert byte array to a string   
                        StringBuilder builder = new StringBuilder();
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            builder.Append(bytes[i].ToString("x2"));
                        }
                        return builder.ToString();
                    }
                }
                RawTextOrHash.Text = ComputeSha256Hash(RawTextOrHash.Text);
                string message = "Your SHA-256 hashed text is : " + RawTextOrHash.Text;
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (algorithm.Text == "File Version")
            {
                File.Decrypt(FilePathTextBox.Text);
                string message = "File decrypted : " + FilePathTextBox.Text + "\n Every account on this computer is now able to open it";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }

            if (algorithm.Text == "Base64")
            {
                RawTextOrHash.Text = Base64Decode(RawTextOrHash.Text);
                RawTextOrHashLabel.Text = "Dehashed Text";
                string message = "Your  Base64 dehashed text is : " + RawTextOrHash.Text;
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
            if (algorithm.Text == "MD5 (Encrypt Only)")
            {
                string message = "Sorry, MD5 does not support decrypt";
                string caption = "MD5";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }

            if (algorithm.Text == "AES-256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);

            }

            if (algorithm.Text == "SHA-256")
            {
                string message = "Coming Soon";
                string caption = "Coming Soon";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, icon);
            }
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (algorithm.Text == "AES-256")
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

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            FilePathTextBox.Text = openFileDialog1.FileName;
        }

        private void FileVersionButton_Click(object sender, EventArgs e)
        {
            RawTextOrHash.Hide();
            RawTextOrHashLabel.Hide();
            BrowseButton.Show();
            FilePathTextBox.Show();
            FileVersionLabel.Show();
            FileVersionButton.Hide();
            TextVersionButton.Show();
            algorithm.Hide();
            algorithm.Text = "File Version";

        }

        private void TextVersionButton_Click(object sender, EventArgs e)
        {
            RawTextOrHash.Show();
            RawTextOrHashLabel.Show();
            BrowseButton.Hide();
            FilePathTextBox.Hide();
            FileVersionLabel.Hide();
            FileVersionButton.Show();
            TextVersionButton.Hide();
            algorithm.Show();
            algorithm.Text = "";
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments =  "/C start https://github.com/squerys",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true
            };
            Process.Start(psi);
        }
    }
}