using System.Collections.Generic;
using System.Linq;

namespace DAL.Models
{
    public class StudentsService
    {
        private MyContext db = new MyContext();
        public List<Student> getAll()
        {
            return db.Students.ToList();
        }
        public Student getByID(int ID)
        {
            return db.Students.Find(ID);
        }
        public void Add(Student std)
        {
            db.Students.Add(std);
            db.SaveChanges();
        }
        public void Edit(Student std)
        {
            Student Student = db.Students.Find(std.ID);
            Student.fname = std.fname;
            Student.lname = std.lname;
            Student.mname = std.mname;
            db.SaveChanges();

        }
        public void Delete(int ID)
        {
            Student Student = db.Students.Find(ID);
            db.Students.Remove(Student);
            db.SaveChanges();
        }
        public Student IsNameExisted(Student std)
        {
            return db.Students.FirstOrDefault(s => s.fname == std.fname);
        }
    }
}
