namespace Personalregister
{
    internal class Robot
    {
        private string _name;


        private int _age;

        public int Age
        {
            get { return _age; }

            set
            {
                if (value < 0)
                    _age = 0;
                else
                    _age = value;
            }
        }

        public static int Count { get; set; } 

        //public int Age { get; set; }

        public int Salary { get;}

        public void SetSalary(int salary)
        {
            //Salary = salary; 
        }


        public Robot(string name, int age, int salary)
        {
            _name = name;
            _age = age;
            Salary = salary;
            Count++; 
        }
        //public Robot(string name)
        //{

        //}
        //public Robot()
        //{

        //}

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            //Validate
            _name = name;
        }


    }
}