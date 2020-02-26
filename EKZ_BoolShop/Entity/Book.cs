using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop.Entity
{
    [Table("tblBook")]
    public class Book
    {
        public Book()
        {

        }

        [Key, ForeignKey("Recommense")]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("CategoryOf")]
        public int Category { get; set; }

        public string Price { get; set; }

        public string SelfPrice { get; set; }

        [ForeignKey("AuthorOf")]
        public int Author { get; set; }

        public string Description { get; set; }

        [ForeignKey("PublisherOf")]
        public int Publisher { get; set; }

        [Required, Range(0, int.MaxValue)]
        public double Pages { get; set; }

        public int Genre { get; set; }

        public DateTime DateOfPublishing { get; set; }

        public virtual Book Recommence { get; set; }

        public virtual Category CategoryOf { get; set; }

        public virtual Author AuthorOf { get; set; }

        public virtual Publisher PublisherOf { get; set; }
    }
}
