using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Service
{
    public class InstructorService
    {
        public List<Instructor> GetAllInstructor()
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            var instructor = instructorRepository.PrintAll();
            return instructor;
        }
        public void AddInstructor(Instructor entity)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            PeopleRepository peopleRepository = new PeopleRepository();
            People people = peopleRepository.PrintOne(entity.ID);
            entity.People = people;
            instructorRepository.Add(entity);
        }
        public Instructor GetOneInstructor(int id)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            return instructorRepository.PrintOne(id);
        }
        public void DeleteInstructor(int id)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            Instructor obj = instructorRepository.PrintOne(id);
            instructorRepository.Delete(obj);
        }
        public void UpdateInstructor(int id)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            Instructor obj = instructorRepository.PrintOne(id);
            instructorRepository.Update(obj);
        }
    }
}
