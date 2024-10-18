using RedeSocial.Domain.Entities.Base;

namespace RedeSocial.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public List<Person> Friends { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
