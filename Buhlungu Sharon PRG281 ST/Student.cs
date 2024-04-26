using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buhlungu_Sharon_PRG281_ST
{

    class Student: IComparer <Student>
    {
        string studName, studentType;
        int studNumber;
        double average, fees, payment,results;
     

        public Student()
        {

        }

        public Student(string studName, string studentType, int studNumber, double average, double fees, double payment, double results)
        {
            this.studName = studName;
            this.studentType = studentType;
            this.studNumber = studNumber;
            this.average = average;
            this.fees = fees;
            this.payment = payment;
            this.results = results;
        }

        public string StudName { get => studName; set => studName = value; }
        public string StudentType { get => studentType; set => studentType = value; }
        public int StudNumber { get => studNumber; set => studNumber = value; }
        public double Average { get => average; set => average = value; }
        public double Fees { get => fees; set => fees = value; }
        public double Payment { get => payment; set => payment = value; }
        public double Results { get => results; set => results = value; }

        public virtual List <Student> CalculatePayment(List<Student> StudentList)
        {
            return StudentList;
        }

        public int Compare(Student x, Student y)
        {
            if (x.StudNumber==y.StudNumber)
            {
                return 0;

            }
            return x.StudNumber.CompareTo(y.StudNumber);


        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
