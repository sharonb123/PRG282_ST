using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Buhlungu_Sharon_PRG281_ST
{
    class PartTime : Student
    {
        
        public PartTime(string studName, string studentType, int studNumber, double average, double fees, double payment, double results) : base(studName, studentType, studNumber, average, fees, payment, results)
        {

        }
        public PartTime()
        {

        }

        public List<Student> PartTimestds(List<Student> StudentList)
        {
            List<PartTime> PartTimeList = new List<PartTime>();
            foreach (var item in StudentList)
            {
                if(item is PartTime)
                {
                    PartTimeList.Add(item as PartTime);
                }
                //item.Fees = item.Fees * 0.10;
            }

            return PartTimeList;
        }

        public override List<Student> CalculatePayment(List<Student> StudentList)
        {
            foreach (var item in StudentList)
            {
                if (item is PartTime)
                {
                    item.Payment = item.Payment * 0.85;
                }
            }
            return base.CalculatePayment(StudentList);



        }

        /*public override string ToString()
        {
            List <Student> StudentList = new List<Student>();   
            
            List<PartTime> PartTimeList = new List<PartTime>();
            foreach (var item in StudentList)
            {
                if (item is PartTime)
                {
                    PartTimeList.Add(item as PartTime);
                };

            }
            return PartTimeList;
        }*/
    }
}
