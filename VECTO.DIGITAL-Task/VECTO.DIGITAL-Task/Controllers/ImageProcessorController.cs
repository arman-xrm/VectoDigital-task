using Microsoft.AspNetCore.Mvc;
using VECTO.DIGITAL_Task.Models.RequestModels;
using VECTO.DIGITAL_Task.Services.Integration;
using VECTO.DIGITAL_Task.Services.Interface;

namespace VECTO.DIGITAL_Task.Controllers
{
    public class ImageProcessorController : ControllerBase
    {
        private readonly IImageProcessor _imageProcessorService;
        public ImageProcessorController(IImageProcessor imageProcessor)
        {
            _imageProcessorService = imageProcessor;
        }

        [HttpGet]
        public async Task<IEnumerable<string>> GetActivePlugins()
        {
            return (IEnumerable<string>)Ok(await _imageProcessorService.GetActivePlugins());
        }

        [HttpPost]
        public async Task<ActionResult<byte[]>> ProcessImage(ProcessImageRequestModel model)
        {
            return Ok(await _imageProcessorService.ApplyEffects(model.Image, model.Radius, model.Size, model.EffectName));
        }
    }
}
