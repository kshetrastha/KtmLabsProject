using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Model
{
   public class UserModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastActiveTime { get; set; }       
    }
}
