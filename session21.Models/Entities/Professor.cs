using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session21.Models.Entities
{
    public class Professor : BaseEntity  
    {
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public string? Field { get; set; }
        public void Read()
        {
            Console.Write("FullName:");
            Fullname = Console.ReadLine();
            Console.Write("Field:");
            Field = Console.ReadLine();
            Console.Write("Address:");
            Address = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{Id} {Fullname} {Field} {Address}";
        }

    }
}
