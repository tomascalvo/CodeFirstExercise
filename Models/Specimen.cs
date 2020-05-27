using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstExercise.Context
{
    public class Specimen
    {
        public enum Sexes 
        {
            Male,
            Female,
            Indeterminate
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Species { get; set; }
        public Sexes Sex { get; set; }
        public int Quantity { get; set; }
        public Specimen()
        {

        }
    }
}