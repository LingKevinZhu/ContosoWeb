using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Models;

namespace Contoso.Service
{
    public class DepartmentsService
    {
        public List<Departments> GetAllDepartments()
        {
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            var departments = departmentsRepository.PrintAll();
            return departments;
        }
        public void AddDepartments(Departments entity)
        {
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            InstructorRepository instructorRepository = new InstructorRepository();
            Instructor instructor = instructorRepository.PrintOne(entity.InstructorID);
            entity.Instructor = instructor;
            departmentsRepository.Add(entity);
        }
        public Departments GetOneDepartments(int id)
        {
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            return departmentsRepository.PrintOne(id);
        }
        public void DeleteDepartments(int id)
        {
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            Departments obj = departmentsRepository.PrintOne(id);
            departmentsRepository.Delete(obj);
        }
        public void UpdateDepartments(Departments obj)
        {
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            departmentsRepository.Update(obj);
        }
    }
}
