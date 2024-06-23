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

namespace School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        List<Students> myList = new List<Students> { };
        public void Txt()
        {
            Random random = new Random();
            int id = random.Next(500, 900);
            string f = "C:\\Users\\HP\\Desktop\\School\\Student\\Student St" + id + "ud.txt";
            if (File.Exists(f))
            {
                int id1 = random.Next(500, 900);
                f = "C:\\Users\\HP\\Desktop\\School\\Student\\Student St" + id1 + "ud.txt";
            }
            string Name = name.Text;
            string father = namefather.Text;
            string mother = namemother.Text;
            string adr = adress.Text;
            string mf;
            if (Male.Checked) mf = Male.Text;
            else mf = Female.Text;
            int Age = Convert.ToInt32(age.Text);
            double Avg = Convert.ToDouble(avg.Text);
            int Number = Convert.ToInt32(number.Text);
            Students student = new Students(Name, father, mother, adr, mf, Age, Avg, Number);
            myList.Add(student);

            try
            {
                using (TextWriter tw = new StreamWriter(f))
                {
                    foreach (Students p in myList)
                    {
                        tw.WriteLine(p.ToString());
                    }
                    tw.Close();
                }
                MessageDialog.Show("Saving Sucssflly", MessageDialogStyle.Light);

            }
            catch (Exception e)
            {
                MessageDialog.Show("Eror PLeas Try Agein" + "\t" + e, MessageDialogStyle.Light);
            }
            MessageDialog.Show("The ID is : " + id.ToString(), MessageDialogStyle.Light);
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Txt();
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