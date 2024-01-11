using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Fundamentals_of_Programming.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageGenerateController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageGenerateController(IImageService imageService) 
        {
            _imageService = imageService;
        }

        [HttpGet]
        public string GenerateDogImage()
        {
            return _imageService.GenerateDog();
        }


    }
}
