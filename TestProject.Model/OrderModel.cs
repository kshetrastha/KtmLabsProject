using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public int UserId { get; set; }
        [Required]
        public string SupplyName { get; set; }
        [Required]
        public decimal UnitCost { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal Markup { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual UserModel User { get; set; }
    }
}
