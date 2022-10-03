using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB
{
    public class Client
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] /* auto incrementable*/
        [JsonIgnore]
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }


        [ForeignKey("IdDocument")]              /* indico cual es la lleva que conecta con la otra tabla */
        [IgnoreDataMember]
        public int IdDocument { get; set; }
         public virtual Document document { get; set; }


        [ForeignKey("IdGenger")]              /* indico cual es la lleva que conecta con la otra tabla */
        [IgnoreDataMember]
        public int IdGenger { get; set; }
        public virtual Genger Genger { get; set; }

    }
}
