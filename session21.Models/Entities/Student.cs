using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session21.Models.Entities
{
    public class Student : BaseEntity
    {
        public string? Fullname { get; set; }
        public double Average { get; set; }
        public string? Field { get; set; }

        public void Read()
        {
            Console.Write("FullName: ");
            Fullname = Console.ReadLine();
            Console.Write("Average: ");
            Average = double.Parse(Console.ReadLine());
            Console.Write("Field: ");
            Field = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{Id} {Fullname} {Field} {Average}";
        }
    }
}
