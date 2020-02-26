﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop.Entity
{
    [Table("tblAuthor")]
    public class Author
    {
        public Author()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Surname { get; set; }

        [Required, StringLength(50)]
        public string Patronymic { get; set; }

        public ICollection<Book> BookOf { get; set; }
    }
}
