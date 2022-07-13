using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceNET.Entities
{
    [Table("DSEmail")]
    public class DSEmail
    {
        
        
            [Key]
            public int idemail { get; set; }

            public string diachiemail { get; set; }
            


        
    }
}
