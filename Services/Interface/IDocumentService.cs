using QLDD.Dtos.Response;

namespace QLDD.Services.Interface
{
    public interface IDocumentService
    {
        public Task<IEnumerable<DocumentDTORes>> GetAll();
        public Task<DocumentDTORes> GetOne(int id);
    }
}
