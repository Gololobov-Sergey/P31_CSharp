using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_CSharp
{
    internal class Student
    {
        static int count = 0;

        public const int MAX = 100;

        public readonly int MIN;

        private int Id = 0;

        string Name = "";

        int age = 0;

        static public int GetCount()
        {
            return count;
        }


        private int myVar;

        public int MyProperty
        {
            get 
            { 
                return myVar; 
            }
            set 
            {
                if(value > 0 && value < 1000)
                    myVar = value; 
            }
        }

        private int myVar1;

        public int MyProperty1
        {
            get { return myVar1; }
            set { myVar1 = value; }
        }


        public int MyProperty2 { get; set; }

        public Student()
        {
            
        }


        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void SetId(int Id)
        {
            this.Id = Id;    
        }

        public void SetAge(int a)
        {
            if (a < 0 || a > 100)
                return;
            age = a;
            count++;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }


        public void Print()
        {
            Console.WriteLine($"Id = {Id}");
        }


    }
}
