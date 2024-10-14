using AutoMapper;
using Digitization.Helpers.CustomException;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using QLDD.Data;
using QLDD.Dtos.Response;
using QLDD.Services.Interface;

namespace QLDD.Services
{
    public class UserService : IUserService
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public UserService(AppDBContext appDBContext, IMapper mapper)
        {
            _context = appDBContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTORes>> GetAll()
        {
            return _mapper.Map<IEnumerable<UserDTORes>>(await _context.Users.ToListAsync());
        }

        public async Task<UserDTORes> GetById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                throw new NotFoundException("not fount user");
            }
            return _mapper.Map<UserDTORes>(user);
        }
    }
}
