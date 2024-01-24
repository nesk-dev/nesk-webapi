using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nesk_webapi.Models
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public Guid PkRoleId { get; set; }    
        public string RoleName { get; set; }
    }
}
