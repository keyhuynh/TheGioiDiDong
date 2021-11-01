using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModel
{
   public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //tự tăng
        public int Id { set; get; }
        [Required]
        public decimal Price { set; get; }
        public DateTime DateCreated { set; get; }
        [MaxLength(250)]
        [Required]
        public string Name { set; get; }
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        public string ThumbnailImage { get; set; }
        [Required]
        public int CategoryId { set; get; }
        [ForeignKey("CategoryId")]
        public Category Category { set; get; }
    }
}
