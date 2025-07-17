using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.WebAPI.DTOs;
using CleanArchitecture.Application;
using CleanArchitecture.Core;


namespace CleanArchitecture.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly RegisterStudentUseCase _useCase;

        public StudentController(RegisterStudentUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] StudentRequestDto dto)
        {
            try
            {
                var student = await _useCase.Execute(dto.Name, dto.Age);

                // Map Entity to DTO
                var response = new StudentResponseDto
                {
                    Id = student.Id,
                    Name = student.Name,
                    Age = student.Age
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }

}
