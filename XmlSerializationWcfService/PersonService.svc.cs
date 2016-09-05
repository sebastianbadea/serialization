using XmlSerializableClasses;

namespace XmlSerializationWcfService
{
    public class PersonService : IPersonService
    {
        public Person GetPerson()
        {
            var person = new Person { Id = "1", Name = "GIGA", Age = 34, Nickname = "THE GREAT", CreditCardPin = "3333", Address = new Address { City = "No kidding", Country = "my country" } };
            return person;
        }

        public Shop GetShop()
        {
            var shop = new Shop { name = "shop's name", rating = 2 };

            return shop;
        }
    }
}
