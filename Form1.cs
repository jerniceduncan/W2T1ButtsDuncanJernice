using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace W2T1ButtsDuncanJernice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student s = new Student();

        private void button1_Click(object sender, EventArgs e)
        {
            s.FName = FName.Text;
            s.LName = LName.Text;
            s.DOB = DOB.Text;
            s.Age = Age.Text;
            s.SSN = SSN.Text;
            s.Phone1 = Phone1.Text;
                s.Phone2 = Phone2.Text;
            s.Addr1 = Addr1.Text;
            s.Addr2 = Addr2.Text;
            s.City = City.Text;
            s.State = State.Text;
            s.Zip = Zip.Text;
                
          
            s.SetStudentID(StudentID.Text);

           


        }
    }
}
