using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using login.Models;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;


namespace login.Controllers
{
//    [Authorize(Roles = "Admin")]
//    public class EditUserController : Controller
//    {
//        public EditUserController()
//        {
//        }

//        public EditUserController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
//        {
//            UserManager = userManager;
//            RoleManager = roleManager;
//        }

//        private ApplicationUserManager _userManager;
//        public ApplicationUserManager UserManager
//        {
//            get
//            {
//                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
//            }
//            private set
//            {
//                _userManager = value;
//            }
//        }

//        private ApplicationRoleManager _roleManager;
//        public ApplicationRoleManager RoleManager
//        {
//            get
//            {
//                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
//            }
//            private set
//            {
//                _roleManager = value;
//            }
//        }
//        // GET: EditUser
//        [HttpGet]
//        public async Task<ActionResult> Index()
//        {
//            return View(await UserManager.Users.ToListAsync());
//        }

//        // GET: EditUser/Details/5
//        [HttpGet]
//        public async Task<ActionResult> Details(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            var user = await UserManager.FindByIdAsync(id);

//            ViewBag.RoleNames = await UserManager.GetRolesAsync(user.Id);

//            return View(user);
//        }
//        // GET: EditUser/Create
//        [HttpGet]
//        public async Task<ActionResult> Create()
//        {
//            //Get the list of Roles
//            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
//            return View();
//        }

//        // POST: EditUser/Create
//        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
//        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Create([Bind(Include = "Id,Email")] RegisterViewModel userViewModel, params string[] selectedRoles)
//        {
//            if (ModelState.IsValid)
//            {
//                var user = new ApplicationUser { UserName = userViewModel.Email, Email = userViewModel.Email };
//                var adminresult = await UserManager.CreateAsync(user, userViewModel.Password);

//                if (adminresult.Succeeded)
//                {
//                    if (selectedRoles != null)
//                    {
//                        var result = await UserManager.AddToRolesAsync(user.Id, selectedRoles);
//                        if (!result.Succeeded)
//                        {
//                            ModelState.AddModelError("", result.Errors.First());
//                            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
//                            return View();
//                        }
//                    }
//                }
//                else
//                {
//                    ModelState.AddModelError("", adminresult.Errors.First());
//                    ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
//                    return View();

//                }

//                return RedirectToAction("Index");
//            }

//            return View();
//        }

//        // GET: EditUser/Edit/5
//        public ActionResult Edit(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            EditUserViewModel editUserViewModel = db.EditUserViewModels.Find(id);
//            if (editUserViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(editUserViewModel);
//        }

//        // POST: EditUser/Edit/5
//        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
//        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Email")] EditUserViewModel editUserViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(editUserViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(editUserViewModel);
//        }

//        // GET: EditUser/Delete/5
//        public ActionResult Delete(string id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            EditUserViewModel editUserViewModel = db.EditUserViewModels.Find(id);
//            if (editUserViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(editUserViewModel);
//        }

//        // POST: EditUser/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(string id)
//        {
//            EditUserViewModel editUserViewModel = db.EditUserViewModels.Find(id);
//            db.EditUserViewModels.Remove(editUserViewModel);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
}
