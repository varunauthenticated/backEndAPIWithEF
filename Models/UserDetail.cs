using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudOperation.Models
{
    public class UserDetail
    {
        [Key]
        public int userId { get; set; }
        [Required]
        [Column(TypeName ="varchar(100)")]
        public string userName { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string userAddress { get; set; }
        [Required]
        [Column(TypeName ="varchar(10)")]
        public string userMobile { get; set; }
    }
}
