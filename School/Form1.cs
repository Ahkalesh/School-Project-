using Guna.UI2.WinForms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static void filwrite()
        {
            string pass = "123456";
            FileStream fileStream = null;
            string filename = "C:\\SchoolProject\\Password.txt";
            try
            {
                fileStream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(pass);
                streamWriter.Close();
                fileStream.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }
        public void pass()
        {

            string Passowrd = "";
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
                MessageDialog.Show("Eror PLeas Try Agein", MessageDialogStyle.Light);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            if (passowrd.Text.Equals(Passowrd))
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "Wrong";
                label1.ForeColor = Color.Red;
            }
        }
        public void pass1()
        {

            string Passowrd = "";
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
                MessageDialog.Show("Eror PLeas Try Agein", MessageDialogStyle.Light);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            if (passowrd.Text.Equals(Passowrd))
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "Wrong";
                label1.ForeColor = Color.Red;
            }
        }
        public void pass2()
        {

            string Passowrd = "";
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
                MessageDialog.Show("Eror PLeas Try Agein", MessageDialogStyle.Light);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            if (passowrd.Text.Equals(Passowrd))
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "Wrong";
                label1.ForeColor = Color.Red;
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pass();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pass1();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pass2();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }

}