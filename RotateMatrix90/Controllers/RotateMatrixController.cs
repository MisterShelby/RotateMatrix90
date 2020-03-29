using Microsoft.AspNetCore.Mvc;
using RotateMatrix.Core.Services;

namespace RotateMatrix.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotateMatrixController : ControllerBase
    {
        private readonly IMatrixRotateService _matrixRotateService;
        public RotateMatrixController(IMatrixRotateService matrixRotateService)
        {
            _matrixRotateService = matrixRotateService;
        }

        [HttpPost]
        public IActionResult RotateMatrix(int[,] inputMatrix)
        {
            _matrixRotateService.RotateMatrix(inputMatrix);

            return Ok(inputMatrix);
        }
    }
}