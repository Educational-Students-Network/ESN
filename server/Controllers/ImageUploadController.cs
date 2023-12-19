using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

public class ImageUploadController: BaseApiController
{
    private readonly IWebHostEnvironment _hostEnvironment;

    public ImageUploadController(IWebHostEnvironment hostingEnvironment)
    {
        _hostEnvironment = hostingEnvironment;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> Upload()
    {
        try
        {
            var file = Request.Form.Files[0];

            if (file.Length > 0)
            {
                
                //this points to root folder on local (D://... and so on)
                //you can customize (idk which path it should be)
                var uploads = Path.Combine(_hostEnvironment.ContentRootPath, "uploads");

                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }

                var filePath = Path.Combine(uploads, DateTime.Now.Ticks + "_" + file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                //return path which is needed
                return Ok(new { Message = "File uploaded successfully", FilePath = filePath });
            }
            else
            {
                return BadRequest("No file received");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}