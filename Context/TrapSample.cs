using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace CodeFirstExercise.Context
{
    public class TrapSample
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Collection { get; set; }
        public string Location { get; set; }
        public string Collector { get; set; }
        public string Analyst { get; set; }
        public List<Specimen> Contents { get; set; }
        
        public TrapSample()
        {

        }
    }
}
