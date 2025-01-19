using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ActionResults.entities
{
    public class Employee
    {
        [Range(1,100)]
        public int Id { get; set; }
       
        [DisplayName("User Name")]
        [Required]
        public string Firstname { get; set; }
        
        [DisplayName("User SurName")]
        [Required]
        public string Lastname { get; set; }
        public int CityId {  get; set; }     
    }
}
