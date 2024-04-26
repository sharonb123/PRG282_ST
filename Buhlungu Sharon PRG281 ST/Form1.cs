using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buhlungu_Sharon_PRG281_ST
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            PartTime part = new PartTime();
            FullTime full = new FullTime();
            PartTime  Anna= new PartTime("anna","part-time",1200, 50, 380.67, 34.567, 123);
            FullTime John = new FullTime("john", "full-time", 1201, 55, 380.67, 34.567, 123);
            studentList.Add(Anna);
            studentList.Add(John);
            


            foreach (var item in studentList)
            {
                item.Fees = double.Parse("R") + item.Fees;
                item.Payment = double.Parse("R") + item.Payment;
               
            }







            bs.DataSource = studentList;
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = bs;


        }

        private void btnToNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnToPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnToLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            List<Student> studentsSearch = new List < Student> ();
            bool test = true;
            foreach (var item in studentList)
            {
                
                if (txtStudent.Text == item.StudNumber.ToString())
                {
                    lblStudentName.Text = item.StudName;
                    lblMark.Text = item.StudName;
                    lblResults.Text = (item.Results).ToString();
                    lblFees.Text = (item.Fees).ToString();
                    lblPayment.Text = (item.Payment).ToString();


                }
            }

            if (test= false)
            {
                MessageBox.Show("student not found");
            }

            bs.DataSource = studentsSearch;
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = bs;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewAllStudents_Click(object sender, EventArgs e)
        {

            bs.DataSource = studentList;
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = bs;
        }

        private void btnViewPartTime_Click(object sender, EventArgs e)
        {
            PartTime pt = new PartTime();
            List<PartTime> displayPartTime = pt.PartTimestds(StudentList);
            

            bs.DataSource = displayPartTime;
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = bs;

        }

        private void btnViewFullTime_Click(object sender, EventArgs e)
        {
            FullTime ft = new FullTime();
            List<FullTime> displayFullTime = ft.FullTimestd(StudentList);
          

            bs.DataSource = displayFullTime;
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = bs;

        }
    }
}
