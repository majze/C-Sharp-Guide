using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace classes
{
    class Person
    {
        // constructors
        public Person()
        {
            Console.WriteLine("Person created.");
        }
        public Person(string initName, int initAge)
        {
            this.name = initName;
            this.age = initAge;
        }

        // destructor - cannot be overloaded or called
        ~Person()
        {
            // cleanup statements
            Console.WriteLine("Killing {0}", name);
            Debug.Write("Destructing Person");
        }

        // member variable
        private string name;
        private int height;
        private int age;
        private double gpa = 4.0;

        // public member method
        public void Gretting()
        {
            if (name != null)
                Console.WriteLine("Hi! I'm {0} and I'm {1} years old", name, age);
        }

        // member method to access private variable
        public void UpdateName(string newName)
        {
            this.name = newName;
        }

        // auto-implemented member property
        public int Weight { get; set; }

        // member property with condition
        public int Height
        {
            get
            {
                return Height;
            }
            set
            {
                if (value < 0) throw new Exception("Can't be negative tall");
                height = value;
            }
        }

        // variable-implemented member property
        public int Age { get => age; set => age = value; }

        // read-only property
        public string GPA
        {
            get
            {
                return string.Format("{0:0.00}", gpa);
            }
        }
    }
}
