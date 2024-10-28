using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Categories
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(15)]
        public string CategoryName { get; set; } = null!;

        public ICollection<Products> Products { get; set; } = null!;
    }
}
