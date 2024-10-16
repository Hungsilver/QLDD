using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QLDD.Data;
using QLDD.Dtos.Response;
using QLDD.Services.Interface;

namespace QLDD.Services
{
    public class DocumentService : IDocumentService

    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public DocumentService(AppDBContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<DocumentDTORes>> GetAll()
        {
            var documents = await _context.Documents
                .AsNoTracking()
                .ToListAsync();
            return _mapper.Map<IEnumerable<DocumentDTORes>>(documents);
        }

        public async Task<DocumentDTORes> GetOne(int id)
        {
            var document = await _context.Documents
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.Id == id);
            return _mapper.Map<DocumentDTORes>(document);
        }
    }
}
