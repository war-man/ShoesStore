using System.Linq;
using CoV.Service.DataModel;
using CoV.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;



namespace CoV.Web.Controllers
{
    public class StudentController : Controller
    {
        #region Property
        private readonly IStudentService _studentService;
        private readonly IClassesService  _classesService;
        private readonly IHostingEnvironment  _hostingEnvironment;
        #endregion
        
        /// <summary>
        /// Constructor StudentController
        /// </summary>
        /// <param name="studentService"></param>
        public StudentController(IStudentService studentService , IClassesService classesService, IHostingEnvironment hostingEnvironment )
        {
            _studentService = studentService;
            _classesService = classesService;
            _hostingEnvironment = hostingEnvironment;

        }
        
        /// <summary>
        /// show entity Student 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Show()
        {
            var student = _studentService.Students();
            return
                View(student);
        }
         
        /// <summary>
        /// view insert a Student
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult  CreateOrUpdate( int id)
        {
            var model = new StudentViewModel();
            model.ClasserModels = _classesService.GetAll().Select(x => new CreateClasserModel()
            {
                ClassMember = x.ClassMember,
                ClassName = x.ClassName,
                Id = x.Id
            }).ToList();
            if (id <= 0)
            {
                model.StudentAvatar = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg";
                return View(model);
            }
            else
            {
                var student = _studentService.GetById(id);
                student.ClasserModels = model.ClasserModels;
                return View(student);
            }
            
        }
        
        /// <summary>
        /// insert a entity su
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrUpdate(StudentViewModel model)
        {
            _studentService.CreateOrUpdate(model);
            return RedirectToAction("Show");
        }

        
        /// <summary>
        /// Controller aciton Delete a Entity Student 
        /// </summary>
        /// <param name="model"></param>
        public IActionResult Delete(int Id)
        {
            _studentService.Delete(Id);
            return RedirectToAction("Show");
        }
    }
}