using knowledgebase.Models;
using Microsoft.AspNetCore.Mvc;


namespace KnowleadgeBase.Controllers
{
    public class FilesController : Controller
    {
        IWebHostEnvironment _hostingEnvironment = null;

        public FilesController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public FileStream FileStream { get; private set; }

        [HttpGet]
        public IActionResult Files(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }

            return View(fileObj);
        }


        [HttpPost]
        public IActionResult Files(IFormFile file, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(FileStream);
                FileStream.Flush();
            }
            return Files();
        }

        public IActionResult PDFViwerNewTab(string filename)
        {
            string path = _hostingEnvironment.WebRootPath + "\\files\\" + filename;
            return File(System.IO.File.ReadAllBytes(path), "application/pdf");
        }
    }
}
