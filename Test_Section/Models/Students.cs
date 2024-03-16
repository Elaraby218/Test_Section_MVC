using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Section.Models
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType("varchar(100)")]
        public string Name { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
