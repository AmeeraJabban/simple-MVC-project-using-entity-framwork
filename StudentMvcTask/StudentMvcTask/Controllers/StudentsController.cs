using System.Web.Mvc;
using StudentMvcTask.Models;

namespace StudentMvcTask.Controllers
{
    public class StudentsController : Controller
    {
    //    public StudentsBLL BLLstudents = new StudentsBLL();
    //    public ActionResult Index()
    //    {
    //        return View(BLLstudents.getAll());
    //    }
    //    public ActionResult Details(int id)
    //    {
    //        Student student = BLLstudents.getByID(id);
    //        return View(student);
    //    }
    //    // GET: Students/Edit/5
    //    public ActionResult Edit(int? id)
    //    {
    //        Student student= new Student();
    //        if (id != null)
    //        {
    //            student = BLLstudents.getByID(id);
    //        }
    //        return View(student);
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Edit(Student student)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            BLLstudents.EditOrAdd(student);
    //            return RedirectToAction("Index");

    //        }
    //        return View(student);
    //    }

    //    public ActionResult Delete(int id)
    //    {
    //        Student student = BLLstudents.getByID(id);
    //        return View(student);
    //    }

    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        BLLstudents.Delete(id);
    //        return RedirectToAction("Index");
    //    }
    }
}
