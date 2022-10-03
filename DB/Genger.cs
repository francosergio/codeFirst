using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace DB
{
    public class Genger
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] /* auto incrementable*/
        public int IdGenger { get; set; }
        public string genger { get; set; }
        public Genger()
        {
        }

    }
}
