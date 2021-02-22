using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleClassification.Model;
using TextAnalysisAPI.Interfaces;
using TextAnalysisAPI.services;

namespace TextAnalysis.Controllers
{ 
    public class ReviewController : BaseApiController 
    {
        private readonly IConsumeModalService _consumeModalService;
        public ReviewController(IConsumeModalService consumeModalService)
        {
            _consumeModalService = consumeModalService;
        }
        [HttpGet]
        public async Task<ActionResult<string>> Get() 
        {
            return Ok("reviewText");
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post(string reviewText)
        {
    
            var sentament =  await _consumeModalService.ReviewTextAsync(reviewText);
            return Ok(sentament);
        }
    }
}