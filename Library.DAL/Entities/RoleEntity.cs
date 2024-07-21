namespace Library.DAL.Entities
{
    public class RoleEntity : BaseEntity<Guid>
    {
        public required string Name { get; set; }
        public virtual IEnumerable<UserEntity> Users { get; set; } = new List<UserEntity>();
    }
}
