using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DB
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] /* auto incrementable*/
        public int IdDocument { get; set; }
        public int DocumentNumber { get; set; }
        public string Abbreviation { get; set; }
        

    }
}
