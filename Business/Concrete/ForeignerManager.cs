using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete {
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            return;
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