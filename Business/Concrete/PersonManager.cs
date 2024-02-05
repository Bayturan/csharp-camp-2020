using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete {
    public class PersonManager : IApplicantService {
        public void ApplyForMask(Person person) {

        }

        public bool CheckPerson(Person person)
        {
            return true;
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}