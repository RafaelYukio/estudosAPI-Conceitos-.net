using RedeSocial.Domain.Entities.Base;
using RedeSocial.Domain.Enums;

namespace RedeSocial.Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public PetType PetType { get; set; } 
    }
}
