namespace FileCrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.algorithm = new System.Windows.Forms.ComboBox();
            this.key = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.RawTextOrHash = new System.Windows.Forms.TextBox();
            this.RawTextOrHashLabel = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.FileVersionLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileVersionButton = new System.Windows.Forms.Button();
            this.TextVersionButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(112, 394);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(94, 29);
            this.decrypt.TabIndex = 0;
            this.decrypt.Text = "decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 394);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(94, 29);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // algorithm
            // 
            this.algorithm.FormattingEnabled = true;
            this.algorithm.Items.AddRange(new object[] {
            "AES-256",
            "Base64",
            "MD5 (Encrypt Only)",
            "SHA-256"});
            this.algorithm.Location = new System.Drawing.Point(585, 394);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(189, 28);
            this.algorithm.TabIndex = 2;
            this.algorithm.SelectedIndexChanged += new System.EventHandler(this.algorithm_SelectedIndexChanged);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(12, 346);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(502, 27);
            this.key.TabIndex = 3;
            this.key.Visible = false;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 314);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(74, 20);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Enter Key:";
            this.KeyLabel.Visible = false;
            // 
            // RawTextOrHash
            // 
            this.RawTextOrHash.Location = new System.Drawing.Point(12, 151);
            this.RawTextOrHash.Name = "RawTextOrHash";
            this.RawTextOrHash.Size = new System.Drawing.Size(583, 27);
            this.RawTextOrHash.TabIndex = 5;
            // 
            // RawTextOrHashLabel
            // 
            this.RawTextOrHashLabel.AutoSize = true;
            this.RawTextOrHashLabel.Location = new System.Drawing.Point(12, 128);
            this.RawTextOrHashLabel.Name = "RawTextOrHashLabel";
            this.RawTextOrHashLabel.Size = new System.Drawing.Size(219, 20);
            this.RawTextOrHashLabel.TabIndex = 6;
            this.RawTextOrHashLabel.Text = "Enter Text to Encrypt or Decrypt";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(601, 149);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(94, 29);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Visible = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(12, 152);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(583, 27);
            this.FilePathTextBox.TabIndex = 8;
            this.FilePathTextBox.Visible = false;
            // 
            // FileVersionLabel
            // 
            this.FileVersionLabel.AutoSize = true;
            this.FileVersionLabel.Location = new System.Drawing.Point(12, 129);
            this.FileVersionLabel.Name = "FileVersionLabel";
            this.FileVersionLabel.Size = new System.Drawing.Size(104, 20);
            this.FileVersionLabel.TabIndex = 9;
            this.FileVersionLabel.Text = "Enter File path";
            this.FileVersionLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileVersionButton
            // 
            this.FileVersionButton.Location = new System.Drawing.Point(12, 185);
            this.FileVersionButton.Name = "FileVersionButton";
            this.FileVersionButton.Size = new System.Drawing.Size(227, 29);
            this.FileVersionButton.TabIndex = 10;
            this.FileVersionButton.Text = "File Crypter/Decryptor";
            this.FileVersionButton.UseVisualStyleBackColor = true;
            this.FileVersionButton.Click += new System.EventHandler(this.FileVersionButton_Click);
            // 
            // TextVersionButton
            // 
            this.TextVersionButton.Location = new System.Drawing.Point(10, 185);
            this.TextVersionButton.Name = "TextVersionButton";
            this.TextVersionButton.Size = new System.Drawing.Size(228, 29);
            this.TextVersionButton.TabIndex = 11;
            this.TextVersionButton.Text = "Text crypter/decryptor";
            this.TextVersionButton.UseVisualStyleBackColor = true;
            this.TextVersionButton.Visible = false;
            this.TextVersionButton.Click += new System.EventHandler(this.TextVersionButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(12, 25);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(107, 82);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 12;
            this.LogoBox.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(125, 25);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(161, 46);
            this.LogoLabel.TabIndex = 13;
            this.LogoLabel.Text = "File Crypt";
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(134, 71);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(141, 20);
            this.GithubLink.TabIndex = 14;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "github.com/Squerys";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.TextVersionButton);
            this.Controls.Add(this.FileVersionButton);
            this.Controls.Add(this.FileVersionLabel);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.RawTextOrHashLabel);
            this.Controls.Add(this.RawTextOrHash);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.key);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Name = "Form1";
            this.Text = "Encrypt/Decrypt";
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button decrypt;
        private Button encrypt;
        private ComboBox algorithm;
        private TextBox key;
        private Label KeyLabel;
        private TextBox RawTextOrHash;
        private Label RawTextOrHashLabel;
        private Button BrowseButton;
        private TextBox FilePathTextBox;
        private Label FileVersionLabel;
        private OpenFileDialog openFileDialog1;
        private Button FileVersionButton;
        private Button TextVersionButton;
        private PictureBox LogoBox;
        private Label LogoLabel;
        private LinkLabel GithubLink;
    }
}