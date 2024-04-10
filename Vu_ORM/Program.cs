using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vu_ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (var db = new Vu_ORMEntities())
            {
                var result = from st in db.tbStudents
                             join fa in db.tbFaculties
                             on st.facultyID equals fa.facultyID
                             where st.studentAge >= 18 && st.studentAge <= 20 && fa.facultyName.Equals("Khoa Công nghệ số")
                             select new { st, fa };
            
                foreach(var item in result)
                {
                    Console.WriteLine("Student ID :{0}", item.st.studentID);
                    Console.WriteLine("Name :{0}", item.st.studentName);
                    Console.WriteLine("Age :{0}", item.st.studentAge);
                    Console.WriteLine("Address :{0}", item.st.address);
                    Console.WriteLine("Faculty :{0}", item.fa.facultyName);
                    Console.WriteLine("-------------------------");
                }
                Console.ReadLine();
            }



        }
    }
}
