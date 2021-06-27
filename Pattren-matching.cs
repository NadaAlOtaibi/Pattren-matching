using System;

namespace Student
{
    class Student
    {
        public int Age { set; get; }
        public string Name { set; get; }



        static void Main(string[] args)
        {
            Student std = new Student();
            int AgeNuber = std.Age = 20;
            string Name = std.Name = "Nada";
            if(AgeNuber is int number)
            {
                    Console.WriteLine($" Has the value {number}");
                }
                else
                {
                    Console.WriteLine("Doesn't has a value");
                }
            if (Name is not null)
            {
                Console.WriteLine($" has the value {Name}");

            }
            else
            {
                Console.WriteLine("doesn't has a value");
            }

        }
            
        }
    }

