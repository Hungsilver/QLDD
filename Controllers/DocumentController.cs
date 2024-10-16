using Microsoft.AspNetCore.Mvc;
using QLDD.Dtos.Response;
using QLDD.Services.Interface;

namespace QLDD.Controllers
{
    [ApiController]
    [Route("/api/v1/Document")]
    public class DocumentController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDocumentService _documentService;
        public DocumentController(IUserService userService, IDocumentService documentService)
        {
            _documentService = documentService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTORes>>> GetAll()
        {
            return Ok(await _documentService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DocumentDTORes>> GetOne(int id)
        {
            return Ok(await _documentService.GetOne(id));
        }
    }
}
