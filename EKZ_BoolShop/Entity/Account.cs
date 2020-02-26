using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop.Entity
{
    [Table("tblAccount")]
    public class Account
    {
        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
