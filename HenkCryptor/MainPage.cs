using System;
using System.Windows.Forms;
using encryption;
using System.Threading;
using System.IO;
using System.Security.Cryptography;

namespace HenkCryptor
{
    public partial class MainPage : Form
    {
        public MainPage() => InitializeComponent();

        private void Encrypt_Click(object sender, EventArgs e)
        {
            this.Text = "Encrypting...";
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                if (File.Exists(path.Text))//files
                {
                    try
                    {
                        if (encrypt_name.Checked)
                        {
                            string Name = Encryption.Encrypt(Aes.Create(), Path.GetFileName(path.Text), password.Text).Replace("\\", "}").Replace("/", "{");
                            FileEncryption.Encrypt(Aes.Create(), path.Text, Path.GetDirectoryName(path.Text) + Path.DirectorySeparatorChar + Name + ".ENCR.HC", password.Text);
                        }
                        else
                            FileEncryption.Encrypt(Aes.Create(), path.Text, path.Text + ".HC", password.Text);

                        if (delete_input.Checked)
                            File.Delete(path.Text);
                    }
                    catch { MessageBox.Show("Could not encrypt file"); }
                }
                else if (Directory.Exists(path.Text))//folders
                {
                    try
                    {
                        if (encrypt_name.Checked)
                        {
                            string Name = Encryption.Encrypt(Aes.Create(), Path.GetFileName(path.Text), password.Text).Replace("\\", "}").Replace("/", "{");
                            FolderEncryption.Encrypt(Aes.Create(), path.Text, Path.GetDirectoryName(path.Text) + Path.DirectorySeparatorChar + Name + ".ENCR.HCF", password.Text);
                        }
                        else FolderEncryption.Encrypt(Aes.Create(), path.Text, path.Text + ".HCF", password.Text);

                        if (delete_input.Checked) Directory.Delete(path.Text, true);
                    }
                    catch
                    {
                        if (File.Exists(path.Text + ".Temp")) File.Delete(path.Text + ".Temp");
                        MessageBox.Show("Could not encrypt folder");
                    }
                }
                else MessageBox.Show("Could not found the file/forlder");
                this.Invoke((MethodInvoker)delegate () {
                    this.Text = "HenkCryptor";
                });
            }).Start();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            this.Text = "Decrypting...";
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                if (File.Exists(path.Text) && path.Text.EndsWith(".HC"))//files
                {
                    try
                    {
                        if (path.Text.EndsWith(".ENCR.HC"))
                        {
                            string Name = Encryption.Decrypt(Aes.Create(), Path.GetFileName(path.Text.Remove(path.Text.Length - 8)).Replace("}", "\\").Replace("{", "/"), password.Text);
                            FileEncryption.Decrypt(Aes.Create(), path.Text, Path.GetDirectoryName(path.Text) + Path.DirectorySeparatorChar + Name, password.Text);
                        }
                        else FileEncryption.Decrypt(Aes.Create(), path.Text, path.Text.Remove(path.Text.Length - 3), password.Text);

                        if (delete_input.Checked) File.Delete(path.Text);
                    }
                    catch { MessageBox.Show("Could not decrypt file"); }
                }
                else if (File.Exists(path.Text) && path.Text.EndsWith(".HCF"))//folders
                {
                    try
                    {
                        if (path.Text.EndsWith(".ENCR.HCF"))
                        {
                            string Name = Encryption.Decrypt(Aes.Create(), Path.GetFileName(path.Text).Remove(Path.GetFileName(path.Text).Length - 9).Replace("}", "\\").Replace("{", "/"), password.Text);
                            if (Directory.Exists(Path.GetDirectoryName(path.Text) + Path.DirectorySeparatorChar + Name)) { MessageBox.Show("Could not decrypt folder, folder already exist."); return; }
                            FolderEncryption.Decrypt(Aes.Create(), path.Text, Path.GetDirectoryName(path.Text) + Path.DirectorySeparatorChar + Name, password.Text);
                        }
                        else
                        {
                            if (Directory.Exists(path.Text.Remove(path.Text.Length - 4))) { MessageBox.Show("Could not decrypt folder, folder already exist."); }
                            FolderEncryption.Decrypt(Aes.Create(), path.Text, path.Text.Remove(path.Text.Length - 4), password.Text);
                        }

                        if (delete_input.Checked) File.Delete(path.Text);
                    }
                    catch
                    {
                        if (File.Exists(path.Text + ".Temp")) File.Delete(path.Text + ".Temp");
                        MessageBox.Show("Could not decrypt folder");
                    }
                }
                else MessageBox.Show("Could not found the file");
                this.Invoke((MethodInvoker)delegate () { this.Text = "HenkCryptor"; });
            }).Start();
        }

        #region password show/hide
        private void off_pw(object sender, EventArgs e) => password.UseSystemPasswordChar = true;

        private void on_pw(object sender, MouseEventArgs e) => password.UseSystemPasswordChar = false;
        #endregion

        private void search_Click(object sender, EventArgs e) { using (OpenFileDialog ofd = new OpenFileDialog()) if (ofd.ShowDialog() == DialogResult.OK) path.Text = ofd.FileName; }

        private void search_folder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK) path.Text = fbd.SelectedPath;
            }
        }
    }
}
