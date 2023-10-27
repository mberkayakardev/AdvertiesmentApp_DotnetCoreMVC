namespace AkarSoftware.Core.Entities.Abstract
{
    /// <summary>
    /// Entity Görevini üstelenen sınıfları bir araya toplayabilmek maksadı ile oluşturulmuş olan bir İnterface dir
    /// </summary>
    public interface IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}
