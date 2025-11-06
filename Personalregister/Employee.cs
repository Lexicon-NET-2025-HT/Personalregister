namespace Personalregister
{
    internal class Employee
    {

        public string Name { get; set; }
        public uint Salary { get; set; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //{
        //    get { 
        //        if(Salary < 25000)
        //        {
        //            return SalaryLevel.Junior;
        //        }
        //        else
        //        {
        //            return SalaryLevel.Senior; 
        //        }
        //    }
        
        //}

        public Employee(string name, uint salary)
        {
            this.Name = name;
            Salary = salary;
        }

        public string Print()
        {
            return $"Name {Name} Salary: {Salary}"; 
        }

        //public override string ToString()
        //{
        //    return $"Name {Name} Salary: {Salary}";
        //}
    }
}