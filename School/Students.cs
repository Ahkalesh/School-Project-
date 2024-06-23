using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Students
    {
        private string name, nameFather, nameMother, adrees, mf;
        private int age;
        private int numper;
        private double avg;
        private int id;


        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                    MessageDialog.Show("Unacceptable", MessageDialogStyle.Light);
                else age = value;
            }
        }
        public double Avg
        {
            get { return avg; }
            set
            {
                if (value < 59.9)
                    MessageDialog.Show("Unacceptable", MessageDialogStyle.Light);
                else avg = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Namefather
        {
            get { return nameFather; }
            set { nameFather = value; }
        }
        public string Namemother
        {
            get { return nameMother; }
            set { nameMother = value; }
        }
        public string Mf
        {
            get { return mf; }
            set { mf = value; }
        }
        public string Adress
        {
            get { return adrees; }
            set { adrees = value; }
        }
        public int Numper
        {
            get { return numper; }
            set { numper = value; }
        }
        public int Id
        {
            get { return id; }
            set
            {

            }
        }
        public Students(string name, string nameFather, string nameMother, string adrees, string mf, int age, double avg, int numper)
        {
            Name = name;
            Namefather = nameFather;
            Namemother = nameMother;
            Adress = adrees;
            Age = age;
            Avg = avg;
            Mf = mf;
            Numper = numper;
            id = Id;
        }
        public override string ToString()
        {
            return "Student{" + " name :" + Name + "   NameFather :" + Namefather +
                "   NameMother :" + Namemother + "   Age :" + Age + "   Avg :" + Avg +
                  "   Mf :" + Mf +
                  "   Adress :" + Adress + "   Numper :" + Numper + " }";
        }
    }

}