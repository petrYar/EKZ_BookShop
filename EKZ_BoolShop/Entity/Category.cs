﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop.Entity
{
    [Table("tblCategory")]
    public class Category
    {
        public Category()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Book> BookOf { get; set; }
    }
}
