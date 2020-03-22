using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Uczelnia 
    {
        public string createdAt { get; set; }
        public string author { get; set; }
        public HashSet<Student> studenci { get; set; }
        public Uczelnia()
        {
            createdAt = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}