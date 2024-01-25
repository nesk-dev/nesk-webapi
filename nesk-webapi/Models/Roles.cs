using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nesk_webapi.Models
{
    [Table("Roles")]
    public class Roles
    {
        public Roles()
        {
            Users = new List<Users>();  
        }

        #region Properties
        [Key]
        public Guid PkRoleId { get; set; }    
        public string? RoleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        #endregion

        #region Associations
        [InverseProperty("Roles")]
        public IList<Users> Users { get; set; }
        #endregion
    }
}
