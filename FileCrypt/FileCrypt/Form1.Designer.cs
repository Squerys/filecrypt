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
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.algorithm = new System.Windows.Forms.ComboBox();
            this.key = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.RawTextOrHash = new System.Windows.Forms.TextBox();
            this.RawTextOrHashLabel = new System.Windows.Forms.Label();
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
            this.RawTextOrHash.Location = new System.Drawing.Point(12, 239);
            this.RawTextOrHash.Name = "RawTextOrHash";
            this.RawTextOrHash.Size = new System.Drawing.Size(583, 27);
            this.RawTextOrHash.TabIndex = 5;
            this.RawTextOrHash.Text = "The quick brown fox jumps over the lazy dog";
            // 
            // RawTextOrHashLabel
            // 
            this.RawTextOrHashLabel.AutoSize = true;
            this.RawTextOrHashLabel.Location = new System.Drawing.Point(12, 212);
            this.RawTextOrHashLabel.Name = "RawTextOrHashLabel";
            this.RawTextOrHashLabel.Size = new System.Drawing.Size(219, 20);
            this.RawTextOrHashLabel.TabIndex = 6;
            this.RawTextOrHashLabel.Text = "Enter Text to Encrypt or Decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RawTextOrHashLabel);
            this.Controls.Add(this.RawTextOrHash);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.key);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Name = "Form1";
            this.Text = "Encrypt/Decrypt";
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
    }
}