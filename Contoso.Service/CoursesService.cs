using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using Contoso.Data;

namespace Contoso.Service
{
    public class CoursesService
    {
        public List<Courses> GetAllCourses()
        {
            CoursesRepository courseRepository = new CoursesRepository();
            var course = courseRepository.PrintAll();
            return course;
        }
        public void AddCourses(Courses entity)
        {
            CoursesRepository courseRepository = new CoursesRepository();
            DepartmentsRepository departmentsRepository = new DepartmentsRepository();
            Departments departments = departmentsRepository.PrintOne(entity.DepartmentID);
            entity.Departments = departments;
            courseRepository.Add(entity);
        }
        public Courses GetOneCourses(int id)
        {
            CoursesRepository coursesRepository = new CoursesRepository();
            return coursesRepository.PrintOne(id);
        }
        public void DeleteCourses(int id)
        {
            CoursesRepository coursesRepository = new CoursesRepository();
            Courses obj = coursesRepository.PrintOne(id);
            coursesRepository.Delete(obj);
        }
        public void UpdateCourses(Courses entity)
        {
            CoursesRepository coursesRepository = new CoursesRepository();
            coursesRepository.Update(entity);
        }
    }
}
