using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace nesk_webapi.Models
{
    public class Users
    {
        #region Properties
        [Key]
        public Guid PkUsersId { get; set; }
        public string UserName { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobileNumber { get; set; }
        public string? Password { get; set; }
        public string? Address { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        #endregion

        #region Associations
        [ForeignKey("FkRoleId")]
        public Roles Roles { get; set; }
        public Guid FkRoleId { get; set; }    
        #endregion
    }
}
