﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingConstructors
{
    class Person
    {
        private string name;
        private int age;
        //public Person(string name, int age)
        //{
        //    this.Age = age;
        //    this.Name = name;
        //}

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //public int Age
        //{
        //    get { return this.age; }
        //    set { this.age = value; }
        //}

        public Person() : this("No name", 1)
        {
        }

        public Person(int age) : this("No name", age)
        {
        }

        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Invalid name");
            }

            this.name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Age
        {
            get { return this.age; }
        }

    }
}
