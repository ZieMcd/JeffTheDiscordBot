using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextAnalysisAPI.Interfaces;

namespace TextAnalysis.Controllers
{

    
    public class ReviewController : BaseApiController 
    {
        private readonly IConsumeModalService modalService;

        public ReviewController(IConsumeModalService modalService)
        {
            this.modalService = modalService;
        }

        public async Task<ActionResult<string>> GetReviewResult(string reviewText) 
        {
            return  "yes";
        }
    }
}