using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwipeChronic.ViewModel;
using SwipeChronic.Models;
using SwipeChronic.Services.Interfaces;

namespace SwipeChronic.Controllers
{
    [Route("api/[controller]")]
    public class PollController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IQuestionServices _questionServices;

        public PollController(
           IMapper mapper,
           IQuestionServices questionServices)
        {
            _mapper = mapper;
            _questionServices = questionServices;
        }

        //GET: api/PollController/RegisterQuestion
        [HttpPost("question")]
        public async Task<IActionResult> RegisterQuestion ([FromBody] QuestionViewModel questionViewModel)
        {   
            var question = _mapper.Map<Question>(questionViewModel);
            await _questionServices.Register(question);
            return Ok();
        }
    }
}
