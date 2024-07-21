using System.ComponentModel.DataAnnotations;

namespace Library.DAL.Entities
{
    public interface IBaseEntity<T>
        where T : notnull
    {
        T Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }

    public class BaseEntity<T> : IBaseEntity<T> 
        where T : notnull
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
