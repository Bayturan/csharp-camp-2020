using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete {
    public class PttManager {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person) {
            PttManager pttManager = new PttManager(new ForeignerManager());
            if(_applicantService.CheckPerson(person)) {
                Console.WriteLine(person.FirstName + "icin maske verildi.");
            }
        }
    }
}