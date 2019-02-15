using HelloMVCApp.DatabaseContext;
using HelloMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCApp.Controllers
{
    public class TraineeController : Controller
    {
        public IActionResult Entry()

        {
            return View();
        }

        [HttpPost]
        public IActionResult Entry(Trainee model)
        {
            if (ModelState.IsValid)
            {
               //database operation to insert trainee
               TrainingDbContext db = new TrainingDbContext();
                db.Trainees.Add(model);
                int successCount = db.SaveChanges();
                if (successCount > 0)
                {
                    //successful!
                }
            }


            return View();
        }

  
        public string List(Trainee[] trainees)
        {
            string nameList = "";
            if (trainees != null && trainees.Length>0)
            {
                foreach (Trainee trainee in trainees)
                {
                    nameList +=  "RegNo: " +trainee.RegNo + " Name: "+trainee.Name +"</br>";
                }
            }

            return nameList;
        }
    }
}