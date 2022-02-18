using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi2.Models;

namespace webapi2.Services
{
    public class PersonService : IPersonService
    {
        public static List<PersonModel> listPerson = new List<PersonModel>(){
            new PersonModel{
                FirstName = "Ngoc Anh",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(2000, 03, 18),
                Gender = "Female",
                BirthPlace = "Thai Nguyen"
            },
            new PersonModel{
                FirstName = "Quang Hung",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(1999, 01, 08),
                Gender = "Male",
                BirthPlace = "Ha Noi"
            },
            new PersonModel{
                FirstName = "Van Tung",
                LastName = "Dinh",
                DateOfBirth = new DateTime(1997, 12, 25),
                Gender = "Male",
                BirthPlace = "Bac Ninh"
            },
            new PersonModel{
                FirstName = "Hai Anh",
                LastName = "Nguyen",
                DateOfBirth = new DateTime(2000, 05, 20),
                Gender = "Female",
                BirthPlace = "Thai Nguyen"
            },
            new PersonModel{
                FirstName = "Thi Van",
                LastName = "Tran",
                DateOfBirth = new DateTime(1995, 08, 15),
                Gender = "Female",
                BirthPlace = "Ha Noi"
            },
        };

        public List<PersonModel> GetAll(){
            return listPerson;
        }

        public void Add(PersonModel person){
            var per = listPerson.FirstOrDefault(p => p.Id == person.Id);
            if(per == null){
                listPerson.Add(person);
            }
        }

        public void Update(Guid id, PersonModel person){
            var personUpdate = listPerson.FirstOrDefault(p => p.Id == id);
            if(personUpdate != null){
                personUpdate.FirstName = person.FirstName;
                personUpdate.LastName = person.LastName;
                personUpdate.DateOfBirth = person.DateOfBirth;
                personUpdate.Gender = person.Gender;
                personUpdate.BirthPlace = person.BirthPlace;
            }
        }

        public void Delete(Guid id){
            var personDelete = listPerson.FirstOrDefault(p => p.Id == id);
            if (personDelete != null){
                listPerson.Remove(personDelete);
            }
        }

        public List<PersonModel> Get(string firstname, string lastname, string gender, string birthplace){
            var listFilter = listPerson.Where(p => String.Equals(p.FirstName,firstname))
            .Where(e => String.Equals(e.LastName,lastname))
            .Where(p => String.Equals(p.Gender.Trim().ToLower(),gender.Trim().ToLower()))
            .Where(p => String.Equals(p.BirthPlace.Trim().ToLower(),birthplace.Trim().ToLower()));

            return listFilter.ToList();
        }
        // public List<PersonModel> GetName(string firstname, string lastname){
        //     var nameFilter = listPerson.Where(p => String.Equals(p.FirstName,firstname)).Where(e => String.Equals(e.LastName,lastname));
        //     return nameFilter.ToList();
        // }

        // public List<PersonModel> GetGender(string gender){
        //     var genderFilter = listPerson.Where(p => String.Equals(p.Gender,gender));
        //     return genderFilter.ToList();
        // }

        // public List<PersonModel> GetBirthPlace(string birthplace){
        //     var birthplaceFilter = listPerson.Where(p => String.Equals(p.BirthPlace, birthplace));
        //     return birthplaceFilter.ToList();
        // }
    }
}