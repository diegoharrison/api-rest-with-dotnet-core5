using api_with_dotnetcore5.Model;
using System.Collections.Generic;

namespace api_with_dotnetcore5.Business.Implementations
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update (Person person);
        void Delete(long id);
    }
}
