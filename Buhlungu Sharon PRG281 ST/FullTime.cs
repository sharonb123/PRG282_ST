using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buhlungu_Sharon_PRG281_ST
{
    class FullTime : Student
    {
        public FullTime()
        {
                
        }
        public FullTime(string studName, string studentType, int studNumber, double average, double fees, double payment, double results) : base(studName, studentType, studNumber, average, fees, payment, results)
        {

        }

        public  List<Student> FullTimestd(List<Student> StudentList)
        {
            List<FullTime> fullTimeList = new List<FullTime>();

            foreach (var item in StudentList)
            {
                if (item is FullTime)
                {
                    fullTimeList.Add(item as FullTime);
                }
               
            }

            return fullTimeList;
            
        }

        public override List<Student> CalculatePayment(List<Student> StudentList)
        {
            foreach (var item in StudentList)
            {
                if (item is FullTime )
                {
                    item.Fees = Fees * 0.15;
                }
            }
            return base.CalculatePayment(StudentList);
        }

        /*public override string ToString()
        {

            List<FullTime> FullTimeList = new List<FullTime>();
            foreach (var item in FullTimeList)
            {
                FullTimeList.Add(item);

            }
            return  FullTimeList.ToString();
        */
    }
    
}
