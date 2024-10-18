namespace RedeSocial.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}
