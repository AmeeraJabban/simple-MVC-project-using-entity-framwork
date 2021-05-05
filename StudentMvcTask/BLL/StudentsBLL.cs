using System.Collections.Generic;
using DAL.Models;

namespace BLL 
{
    public class StudentsBLL
    {
        StudentsService studentsService = new StudentsService();

        public IList<Student> getAll()
        {
            return studentsService.getAll();
        }
        public Student getByID(int ID)
        {
            return studentsService.getByID(ID);
        }
        public void Add(Student std)
        {
            studentsService.Add(std);
        }
        public void Edit(Student std)
        {
            studentsService.Edit(std);
        }
        public void Delete(int ID)
        {
            studentsService.Delete(ID);
        }
        public Student IsNameExisted(Student std) {
            return studentsService.IsNameExisted(std);
        }
        public void EditOrAdd(Student student)
        {

            Student nameAlreadyExists = IsNameExisted(student);
            Student studentw = getByID(student.ID);
            if (studentw != null)
            {
                if ((nameAlreadyExists != null) && (studentw.ID != student.ID))
                {
                   // ModelState.AddModelError("fname", "Student Name Already Exists.");
                }
                else
                {
                    Edit(student);
                }
            }
            else
            {
                if (nameAlreadyExists != null)
                {
                   // ModelState.AddModelError("fname", "Student Name Already Exists.");
                }
                else
                {
                    Add(student);
                }

            }
        }
    }
}
