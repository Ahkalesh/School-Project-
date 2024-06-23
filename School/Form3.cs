using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace School
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        void EditPassword()
        {
            string Passowrd = null;
            string newPass = passowrd.Text;
            FileStream fileStream = null;
            string filename = "C:\\SchoolProject\\Password.txt";
            try
            {
                fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                Passowrd = streamReader.ReadToEnd();
                streamReader.Close();
                fileStream.Close();
            }
            catch (Exception Ex)
            {
                MessageDialog.Show("Error PLeas Try Agein", MessageDialogStyle.Light);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }

            if (Passowrd.Equals(oldPassword.Text) && newPass.Equals(confirm.Text))
            {
                label1.Text = "Corect";
                label1.ForeColor = Color.Green;
                File.Delete(filename);
                try
                {
                    fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.Write(newPass);
                    streamWriter.Close();
                    fileStream.Close();
                    MessageDialog.Show("Saving Sucssflly", MessageDialogStyle.Light);
                }
                catch (Exception Ex)
                {
                    MessageDialog.Show("Error PLeas Try Agein", MessageDialogStyle.Light);
                }
                finally
                {
                    if (fileStream != null)

                        fileStream.Close();
                }
            }
            else
            {
                label1.Text = "UnCorect";
                label1.ForeColor = Color.Red;
            }
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            EditPassword();
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
