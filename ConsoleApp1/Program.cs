// INFO: used for info that should be replaced while writing lab report
using Ques8;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            // Ques8Demo.Run();
            Ques12Demo();
        }
        public static void Ques1Demo()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number is even? " + (n % 2 == 0));
            Console.ReadKey();
        }

        public static void Ques2Demo()
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        public static void Ques3Demo()
        {
            int[,] arr = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
        };

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            /*
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
        }

        public static void Ques4Demo()
        {
            int[,] a = {
            {1, 2 },
            {3, 4 },
        };
            int[,] b = {
            {1, 2 },
            {3, 4 },
        };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Ques5Demo()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }

        public static void Ques6Demo()
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {n} is {fact}");
        }

        // Ques11
        public class Employee {
            public string Name;
            public string Address;
            public int Salary;

            public Employee(string name, string address, int salary) {
                this.Name = name;
                this.Address = address;
                this.Salary = salary;
            }
        }

        public static void Ques11Demo() {
            List<Employee> employees = new List<Employee>() {
                new Employee("Sujal", "Kathmandu", 9000),
                new Employee("Hari", "Kathmandu", 1500),
                new Employee("Samip", "Pokhara", 20000),
            };

            var filtered = from e in employees
                where e.Address.Contains("Kathmandu") && e.Salary > 10000
                select e;

            Console.WriteLine("employees living in Kathmandu AND having salary greater than 10000: ");
            foreach(Employee e in filtered) {
                Console.WriteLine(e.Name);
            }
        }

        // Ques12
        public class Student {
            public string Name;
            public string Address;
            public string College;

            public Student(string name, string address, string college) {
                this.Name = name;
                this.Address = address;
                this.College = college;
            }
        }

        public static void Ques12Demo() {

            List<Student> students = new List<Student>() {
                new Student("Sujal", "Kathmandu", "Himalaya"),
                new Student("Hari",  "Kathmandu", "Deerwalk"),
                new Student("Samip", "Kathmandu", "Deerwalk"),
                new Student("Arpan", "Pokhara",   "Deerwalk"),
            };

            var filtered = students.Where(s => s.Address.Contains("Kathmandu") && s.College.Contains("Deerwalk") );

            Console.WriteLine("Students living in Kathmandu & studying in Deerwalk are: ");
            foreach(var s in filtered) {
                Console.WriteLine(s.Name);
            }
        }

    }

    public class Ques9
    {
        // INFO: replace Ques9 classname w/ Complex
        public bool a;
        public bool b;
        public Ques9() { }
        public Ques9(bool a, bool b)
        {
            this.a = a;
            this.b = b;
        }

        public static bool operator &(Ques9 q91, Ques9 q92) {
            return q91.a && q91.b && q92.a && q92.b;
        }

        public static bool operator | (Ques9 q91, Ques9 q92) {
            return q91.a || q91.b || q92.a || q92.b;
        }
    }

    public class Ques9Demo {
        public static void Run() {
            Ques9 q1 = new Ques9(true, true);
            Ques9 q2 = new Ques9(true, false);
            Console.WriteLine($"AND result: { q1 & q2 }");
            Console.WriteLine($"OR result:  { q1 | q2 }");
        }
    }

    public class IneligibleVoteException : Exception {
        public IneligibleVoteException() { }
        public IneligibleVoteException(string message): base(message) {}
    }

    public class Ques10 {
        // INFO: replace Ques10 classname w/ Citizen
        public int age {
            get { return age; }
            set {
                try {
                    if (value < 18) throw new IneligibleVoteException("Too young to vote");
                    else this.age = value;
                } catch(IneligibleVoteException e) {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
        }
    }

    public class Ques10Demo {
        // INFO: put this in Main
        public static void Run() {
            Ques10 c1 = new Ques10();
            c1.age = 17;
        }
    }
}

// Ques7 
namespace Name1
{
    public class C1
    {
        public C1()
        {
            Console.WriteLine("Class C1 instantiated");
        }
    }
}

namespace Name2
{
    using Name1;
    public class C2
    {
        C1 c = new C1();
    }
}
