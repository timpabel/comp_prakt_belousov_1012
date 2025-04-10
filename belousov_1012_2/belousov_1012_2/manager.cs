using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belousov_1012_2
{
    internal class Manager:Employer
    {
        private decimal bonus;
        public Manager(string fio, decimal salary, DateTime datebegining, decimal bonus):base(fio,salary,datebegining) 
        {
            this.bonus = bonus;
            Debug.WriteLine("конструктор Manager с 3+1 параметрами" + this);
        }
        public Manager(string fio, DateTime datebegining, decimal bonus) : base(fio, datebegining)
        {
            this.bonus = bonus;
            Debug.WriteLine("конструктор Manager с 3+1 параметрами" + this);
        }
        public override string ToString()
        {
            return $"Менеджер: {base.Id}: {base.Fio}, {getSalary()}, {base.Datebegining.Year}";
        }
        public override decimal getSalary()
        {
            return base.Salary+bonus;
        }
    }
}
