using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        void Read()
        {
            int id = Convert.ToInt32(IDD.Text);
            string f = "C:\\Users\\HP\\Desktop\\School\\Student\\Student St" + id + "ud.txt";
            if (!(File.Exists(f)))
            {
                MessageDialog.Show("Eror PLeas Try Agein", MessageDialogStyle.Light);
            }
            else
            {
                using (FileStream fileStream = new FileStream(f, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        TextReader sr = new StreamReader(fileStream);
                        var item = sr.ReadToEnd();
                        sr.Close();
                        guna2TextBox1.Text = item;
                    }
                    catch (FileNotFoundException e)
                    {
                        MessageDialog.Show("not Found" + e, MessageDialogStyle.Light);
                    }
                    catch (SerializationException e)
                    {
                        MessageDialog.Show("Eror PLeas Try Agein" + e, MessageDialogStyle.Light);
                    }
                }

            }

        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Read();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
