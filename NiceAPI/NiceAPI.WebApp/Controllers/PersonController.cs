using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NiceAPI.DataLayer;

namespace NiceAPI.WebApp.Controllers
{
    [Route("patika/hw01/NiceAPI/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            List<Person> person = unitOfWork.PersonRepository.GetAll();
            return person;

        }

        [HttpGet("{id}")]
        public Person GetById(int id)
        {
            Person person = unitOfWork.PersonRepository.GetById(id);
            return person;
        }

        [HttpGet("GetFilterByName/{name}")]
        
        public IEnumerable<Person> GetWithWhere(string name)
        {
            IEnumerable<Person> persons = unitOfWork.PersonRepository.Where(e => e.FirstName == name);
            return persons;
        }

        [HttpDelete("{id}")]
        public OkResult Delete(int id)
        {
            unitOfWork.PersonRepository.Remove(id);
            return Ok();
        }

        [HttpPost]
        public void Post(Person person)
        {
            unitOfWork.PersonRepository.Insert(person);
        }


        [HttpPut]
        public void Put(Person person)
        {
            unitOfWork.PersonRepository.Update(person);
        }

        [HttpGet("GetFilterByFullName")]
        
        public IEnumerable<Person> GetPeopleByName([FromQuery] string name, string lastname)
        {
            IEnumerable<Person> persons = unitOfWork.PersonRepository.Where(p => p.FirstName.Contains(name) && p.LastName.Contains(lastname)).ToList();
            return persons;
        }
    }
}
