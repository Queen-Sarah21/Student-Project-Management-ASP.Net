using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMTIWebSite.Models;

namespace SMTIWebSite.Controllers
{
    public class AssignmentsController : Controller
    {
        private SMTIDatabaseEntities db = new SMTIDatabaseEntities();

        // GET: Assignments
        public ActionResult Index()
        {
            var assignments = db.Assignments.Include(a => a.Project).Include(a => a.Student);
            return View(assignments.ToList());
        }

        // GET: Assignments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // GET: Assignments/Create
        public ActionResult Create()
        {
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle");
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName");
            return View();
        }

        // POST: Assignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,ProjectCode,StudentNumber,AssignmentDate")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                //check if the project has been assigned to the student
                var studProj = db.Assignments.Where(x => x.StudentNumber == assignment.StudentNumber 
                                                    && x.ProjectCode == assignment.ProjectCode).FirstOrDefault();
                if (studProj != null)
                {
                    ViewData["Error"] = "This project has been assigned to this student";
                }
                else
                {
                    db.Assignments.Add(assignment);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", assignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", assignment.StudentNumber);
            return View(assignment);
        }

        // GET: Assignments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", assignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", assignment.StudentNumber);
            return View(assignment);
        }

        // POST: Assignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,ProjectCode,StudentNumber,AssignmentDate")] Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProjectCode = new SelectList(db.Projects, "ProjectCode", "ProjectTitle", assignment.ProjectCode);
            ViewBag.StudentNumber = new SelectList(db.Students, "StudentNumber", "FirstName", assignment.StudentNumber);
            return View(assignment);
        }

        // GET: Assignments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = db.Assignments.Find(id);
            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }

        // POST: Assignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assignment assignment = db.Assignments.Find(id);
            db.Assignments.Remove(assignment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
