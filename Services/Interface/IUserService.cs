using QLDD.Dtos.Response;

namespace QLDD.Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTORes>> GetAll();
        Task<UserDTORes> GetById(int id);
    }
}
