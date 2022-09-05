using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_DAL.Entities
{
    public class Warehouse
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
    }
}
