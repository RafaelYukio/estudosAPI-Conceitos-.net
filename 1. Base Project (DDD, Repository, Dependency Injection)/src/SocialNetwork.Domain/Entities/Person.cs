using RedeSocial.Domain.Entities.Base;

namespace RedeSocial.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        //One to one
        public Person BestFriend { get; set; }
        //N to N
        public List<Person> Friends { get; set; }
        //One to N
        public List<Pet> Pets { get; set; }
    }
}
