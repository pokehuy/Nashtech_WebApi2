using webapi2.Models;

namespace webapi2.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetAll();

        void Add(PersonModel person);

        void Update(Guid id, PersonModel person);

        void Delete(Guid id);

        List<PersonModel> Get(string firstname, string lastname, string gender, string birthplace);
        // List<PersonModel> GetName(string firstname, string lastname);

        // List<PersonModel> GetGender(string gender);

        // List<PersonModel> GetBirthPlace(string birthplace);
    }
}