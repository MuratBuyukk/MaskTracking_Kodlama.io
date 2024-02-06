using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person)) 
            {
                Console.WriteLine("The mask was successfully given to " + person.FirstName);
            }
            else
            {
                Console.WriteLine("The mask couldn't be given to " + person.FirstName + ". The person's information couldn't be verified.");
            }
        }
    }
}
