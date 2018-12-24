namespace HenkCryptor
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.delete_input = new System.Windows.Forms.CheckBox();
            this.encrypt_name = new System.Windows.Forms.CheckBox();
            this.search_folder = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt.FlatAppearance.BorderSize = 0;
            this.Encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.ForeColor = System.Drawing.Color.White;
            this.Encrypt.Location = new System.Drawing.Point(12, 79);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(125, 25);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt.FlatAppearance.BorderSize = 0;
            this.Decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Decrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.ForeColor = System.Drawing.Color.White;
            this.Decrypt.Location = new System.Drawing.Point(147, 79);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(125, 25);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(12, 32);
            this.password.MaxLength = 1000;
            this.password.Name = "password";
            this.password.ShortcutsEnabled = false;
            this.password.Size = new System.Drawing.Size(234, 13);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // path
            // 
            this.path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.White;
            this.path.Location = new System.Drawing.Point(12, 51);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(208, 13);
            this.path.TabIndex = 3;
            // 
            // delete_input
            // 
            this.delete_input.Appearance = System.Windows.Forms.Appearance.Button;
            this.delete_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.delete_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_input.FlatAppearance.BorderSize = 0;
            this.delete_input.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.delete_input.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.delete_input.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.delete_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_input.ForeColor = System.Drawing.Color.White;
            this.delete_input.Location = new System.Drawing.Point(142, 6);
            this.delete_input.Name = "delete_input";
            this.delete_input.Size = new System.Drawing.Size(130, 20);
            this.delete_input.TabIndex = 32;
            this.delete_input.Text = "delete input";
            this.delete_input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_input.UseVisualStyleBackColor = false;
            // 
            // encrypt_name
            // 
            this.encrypt_name.Appearance = System.Windows.Forms.Appearance.Button;
            this.encrypt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.encrypt_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt_name.FlatAppearance.BorderSize = 0;
            this.encrypt_name.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.encrypt_name.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.encrypt_name.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.encrypt_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_name.ForeColor = System.Drawing.Color.White;
            this.encrypt_name.Location = new System.Drawing.Point(12, 6);
            this.encrypt_name.Name = "encrypt_name";
            this.encrypt_name.Size = new System.Drawing.Size(130, 20);
            this.encrypt_name.TabIndex = 33;
            this.encrypt_name.Text = "encrypt name";
            this.encrypt_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.encrypt_name.UseVisualStyleBackColor = false;
            // 
            // search_folder
            // 
            this.search_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.search_folder.BackgroundImage = global::HenkCryptor.Properties.Resources.folder;
            this.search_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_folder.FlatAppearance.BorderSize = 0;
            this.search_folder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.search_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.search_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_folder.ForeColor = System.Drawing.Color.White;
            this.search_folder.Location = new System.Drawing.Point(226, 50);
            this.search_folder.Name = "search_folder";
            this.search_folder.Size = new System.Drawing.Size(20, 15);
            this.search_folder.TabIndex = 34;
            this.search_folder.UseVisualStyleBackColor = false;
            this.search_folder.Click += new System.EventHandler(this.search_folder_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.search.BackgroundImage = global::HenkCryptor.Properties.Resources.search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(252, 50);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(20, 15);
            this.search.TabIndex = 28;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button3.BackgroundImage = global::HenkCryptor.Properties.Resources.eye;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(252, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 15);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.off_pw);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.on_pw);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.search_folder);
            this.Controls.Add(this.encrypt_name);
            this.Controls.Add(this.delete_input);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.path);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 155);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 155);
            this.Name = "MainPage";
            this.Text = "HenkCryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.CheckBox delete_input;
        private System.Windows.Forms.CheckBox encrypt_name;
        private System.Windows.Forms.Button search_folder;
    }
}

