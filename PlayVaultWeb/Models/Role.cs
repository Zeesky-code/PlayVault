using PlayVaultWeb.Enums;

namespace PlayVaultWeb.Models
{
    public class Role
    {
        public int Id { get; set; }
        public TypeOfRole RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
