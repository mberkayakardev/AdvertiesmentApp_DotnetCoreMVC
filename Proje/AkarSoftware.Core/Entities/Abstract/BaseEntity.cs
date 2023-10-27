namespace AkarSoftware.Core.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
