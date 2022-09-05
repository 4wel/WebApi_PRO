using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi_DAL.Entities
{
    public class Good
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}