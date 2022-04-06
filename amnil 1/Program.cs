using System;

namespace amnil_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo su = new StudentInfo();
            Console.WriteLine("Full Name:" + "  " + su.LastName + " " + su.LastName);
            Console.WriteLine("College Name:" + "  " + su.College);
            Console.WriteLine(" Major Subject:" + "  " + su.MajourSUB);


        }
        public class StudentInfo
    {
            public string FirstName = "Sumeru";
            public string LastName = "Singh";
            public string College = "Khwopa Engineering College";
            public string MajourSUB = "C/c++";




        }
    }
}
