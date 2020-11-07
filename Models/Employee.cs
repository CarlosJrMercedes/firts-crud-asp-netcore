using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWeb.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public Position position{ get; set; }
    }
}
