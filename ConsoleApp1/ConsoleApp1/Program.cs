using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        private static StreamWriter error_file;
        
        public static void log(string line)
        {
            
            error_file.WriteLine(line);
        }
        static void Main(string[] args)
        {
            //blad
            string path = args.Length > 0 ? args[0] :  "data.csv";
            string path2 = args.Length > 1 ? args[1] : "result.xml";
            string path3 = args.Length > 2 ? args[2] : "xml";
            
            error_file = new StreamWriter("log.txt",true);
            error_file.WriteLine("log");

           
            if (!System.IO.Directory.Exists(path))
            {
                log($"Directory\"{path}\"doesn't exists' ");
                error_file.Flush();
                error_file.Close();
                
            }
            
                var students = new HashSet<Student>(new StudentComparer());
            
                var file = new FileInfo("/Users/koval/dane.csv");

                using (var stream = new StreamReader(file.OpenRead()))
                {
                    string line = null;
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] student = line.Split(',');
                        var st = new Student
                        {
                            fname = student[0],
                            lname = student[1],
                            studies = new Studies
                            {
                                name = student[2],
                                mode = student[3]
                            },
                            indexNumber = int.Parse(student[4]),
                            birthdate = student[5],
                            email = student[6],
                            mothersName = student[7],
                            fatherName = student[8]
                        };
                        students.Add(st);
                    }
                }

                var uczelnia = new Uczelnia
                {
                    author = "Anastasiia Koval",
                    studenci = students
                };
            FileStream writer = new FileStream(path2, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Uczelnia));
           
            serializer.Serialize(writer, uczelnia);
            Console.WriteLine();
        }
        
    }
}