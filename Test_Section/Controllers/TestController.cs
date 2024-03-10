using Microsoft.AspNetCore.Mvc;

namespace Test_Section.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test_index()
        {
            return View();
        }

        public EmptyResult Test_EmptyResult()
        {
            return new EmptyResult();
        }

        public string Test_String()
        {
            return "Hi i'am mohamed Ramadan Elaraby";
        }

        public ContentResult Test_Content()
        {
            return Content("Hi Iam mohamed Elaraby");
        }

        public RedirectToActionResult Test_redirctaction()
        {
            return RedirectToAction("Test_index");
        }

        public RedirectResult Test_redirectresult()
        {
            return Redirect("https://wallpaperaccess.com/palestine-flag");
        }


        public ActionResult GetImage()
        {
            // Path to your image file
            string imagePath = "C:\\Users\\Administrator\\Downloads\\time8.jpg";

            // Check if the file exists


            // Read the image file
            byte[] imageData = System.IO.File.ReadAllBytes(imagePath);

            // Determine the MIME type
            string mimeType = "image/jpeg"; // Change this according to your image type

            // Return the image file
            return File(imageData, mimeType);


        }
    }
}
