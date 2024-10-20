using RedeSocial.Domain.Entities.Base;
using RedeSocial.Domain.Enums;

namespace RedeSocial.Domain.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PetType PetType { get; set; } 
        public Person Owner { get; set; }
    }
}
