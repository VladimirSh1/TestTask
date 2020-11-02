using System;

namespace TestTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bigBoss = new Employee("Иван", "Иванович", "Иванов", 
                "Генеральный директор", "Администрация", 100m);
            Employee chiefAccountant = new Employee("Борис", "Петрович", "Сидоров", 
                "Главный бухгалтер", "Бухгалтерия", 80m);

            Console.WriteLine(bigBoss);
            Console.WriteLine(chiefAccountant);

            Point p1 = new Point();
            Point p2 = new Point() { X = 3.0, Z = 4.0 };

            Console.WriteLine($"  Точка  p1: x={p1.X,-5} y={p1.Y,-5} z={p1.Z,-5}");
            Console.WriteLine($"  Точка  p2: x={p2.X,-5} y={p2.Y,-5} z={p2.Z,-5}");
            Console.WriteLine($"  Расстояние между p1 и p2: {p1.DistanseTo(p2)}\n");
        }
    }


    class Employee
    {
        public string Name { set; get; }
        public string Patronymic { set; get; }
        public string Surname { set; get; }
        public string JobPost { set; get; }
        public string Department { set; get; }
        public decimal Salary { set; get; }

        public Employee(string Name, string Patronymic, string Surname, 
            string JobPost, string Department, decimal Salary)
        {
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Surname = Surname;
            this.JobPost = JobPost;
            this.Department = Department;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return string.Format("  {0,-11}{1}\n  {2,-11}{3}\n  {4,-11}{5}\n  " +
                "{6,-11}{7}\n  {8,-11}{9}\n  {10,-11}{11} руб.\n", 
                "Имя:", Name, "Отчество:", Patronymic, "Фамилия:", Surname,
                "Должность:", JobPost, "Отдел:", Department,"Оклад:", Salary);
        }
    }

    class Point
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double Z { get; set; } = 0;

        public double DistanseTo(Point point)
        {
            return Math.Sqrt(Math.Pow(point.X - X, 2) + 
                Math.Pow(point.Y - Y, 2) + 
                Math.Pow(point.Z - Z, 2));
        }
    }
}
