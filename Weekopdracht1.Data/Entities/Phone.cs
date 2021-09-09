using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekopdracht1.Data.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public string Merk { get; set; }
        public string PhoneType { get; set; }
        public string Omschrijving { get; set; }
        public int Prijs { get; set; }
    }
}
