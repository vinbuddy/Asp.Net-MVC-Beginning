﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstApp.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }

        public int age { get; set; }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }

    }

    
}