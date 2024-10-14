using QLDD.Dtos.Response;
using QLDD.Models;

namespace QLDD.Services.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTORes>> GetAll();
        Task<IEnumerable<User>> GetAllNoDTO();
        Task<UserDTORes> GetById(int id);
    }
}
