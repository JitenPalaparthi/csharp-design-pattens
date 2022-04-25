using System;

namespace PrototypeExample
{

    public class Employee
    {
        public string Name;
        public string Email;

        public IDVar idvar;

        public Employee Copy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee Clone()
        {
            Employee clone = (Employee)this.MemberwiseClone();
            clone.idvar = new IDVar(idvar.id);
            clone.Name = new String(Name);
            clone.Email = new String(Email);
            return clone;
        }

        public class IDVar
        {
            public int id;

            public IDVar(int _id)
            {
                this.id = _id;
            }

        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee();

            e1.Name = "Jiten";
            e1.Email = "JitenP@Outlook.Com";
            e1.idvar = new Employee.IDVar(101);
            Display(e1);
            Employee e2 = e1.Copy();
            Console.WriteLine("--------------------");
            Display(e1);
            Employee e3 = e1.Clone();
            Console.WriteLine("--------------------");
            Display(e3);

            e1.Name = "Jiten P";
            e1.Email = "Jiten.Palaparthi@Gamil.Com";
            e1.idvar.id = 999;

            Display(e1);
            //Employee e2 = e1.Copy();
            Console.WriteLine("--------------------");
            Display(e1);
            //Employee e3 = e1.Clone();
            Console.WriteLine("--------------------");
            Display(e3);
        }
        public static void Display(Employee e)
        {
            Console.WriteLine("Name:{0:s},Email:{1:s}", e.Name, e.Email);
            Console.WriteLine("IDVar:{0:d}", e.idvar.id);
        }

    }
}
