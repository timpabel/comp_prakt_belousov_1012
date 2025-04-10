using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belousov_1012_2
{
    public  class Employer
    {
        private string fio;
        private decimal salary;
        private DateTime datebegining;
        private string id;
        private static int count;
        private static decimal startSalary = 1000;

        public Employer(string fio, decimal salary, DateTime datebegining)
        {
            this.fio = fio;
            this.salary = salary;
            this.datebegining = datebegining;
            count++;
            setId();
            
        }
        public Employer(string fio, decimal salary)
        {
            this.fio = fio;
            this.salary = salary;
            this.datebegining = DateTime.Now;
            count++;
            setId();

        }
        public Employer(string fio, DateTime datebegining)
        {
            this.fio = fio;
            this.salary = startSalary;
            this.datebegining = datebegining;
            count++;
            setId();

        }
        private void setId()
        {
            this.id = this.fio[0].ToString()+count;
        }
        public override string ToString()
        {
            return $"{this.id}: {this.fio}, {this.salary}, {this.datebegining.Year}" ;
        }

    }
}
