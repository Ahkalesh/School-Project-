using Guna.UI2.WinForms;


namespace School
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        void Edit()
        {
            List<Students> myList = new List<Students> { };
            Console.WriteLine("Enter Id of stydent");
            int id = Convert.ToInt32(Id.Text);
            string f = "C:\\Users\\HP\\Desktop\\School\\Student\\Student St" + id + "ud.txt";
            if (!(File.Exists(f)))
            {
                MessageDialog.Show("Eror PLeas Try Agein", MessageDialogStyle.Light);
            }
            else
            {
                File.Delete(f);
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
                    foreach (Students s in myList)
                    {
                        tw.WriteLine(s);
                    }
                    tw.Close();
                }
                MessageDialog.Show("Saving Sucssflly", MessageDialogStyle.Light);
            }
            catch (Exception e)
            {
                MessageDialog.Show("Eror" + e, MessageDialogStyle.Light);
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Edit();
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
