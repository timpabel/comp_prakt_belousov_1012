using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belousov_1012_2
{
    public class Employer
    {
        private string fio;
        private decimal salary;
        private DateTime datebegining;
        private string id;
        private static int count;

        public Employer()
        {
            this.Fio = "";
            this.Salary = 0;
            this.Datebegining = DateTime.Now;
            Debug.WriteLine("конструктор emploee с 0 параметрами" + this);

        }
        public Employer(string fio, decimal salary, DateTime datebegining)
        {
            this.Fio = fio;
            this.Salary = salary;
            this.Datebegining = datebegining;
            count++;
            setId();
            Debug.WriteLine("конструктор emploee с 3 параметрами" + this);

        }
        public Employer(string fio, decimal salary)
        {
            this.Fio = fio;
            this.Salary = salary;
            count++;
            setId();
            Debug.WriteLine("конструктор emploee с 2 параметрами" + this);

        }
        public Employer(string fio, DateTime datebegining)
        {
            this.Fio = fio;
            this.Datebegining = datebegining;
            count++;
            setId();
            Debug.WriteLine("конструктор emploee с 2 параметрами" + this);
        }

        private void setId()
        {
            this.Id = this.Fio[0].ToString() + count;
        }
        public int CalculateStage()
        {
            DateTime today = DateTime.Today;
            int years = today.Year - datebegining.Year;

            if (datebegining.Date > today.AddYears(-years))
            {
                years--;
            }

            return years;
        }
        public void ChangeSalary(decimal newSalary)
        {
            salary = newSalary;
        }
        public string Fio { get; set; }
        public decimal Salary { get; set; }
        public DateTime Datebegining { get; set; }
        public string Id { get; set; }
        public virtual decimal getSalary()
        {
            return this.Salary;
        }
        public override string ToString()
        {
            return $"Сотрудник: {this.Id}: {this.Fio}, {this.getSalary()}, {this.Datebegining.Year}";
        }
    }
}