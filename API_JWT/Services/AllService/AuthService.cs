using API_JWT.Data;
using API_JWT.DTO;
using API_JWT.Models;

namespace API_JWT.Services.AllService
{
    public class AuthService : IAuthInterface
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Response<UserCreateDTO>> Register(UserCreateDTO usserRegister) 
        {
            Response<UserCreateDTO> responseService = new Response<UserCreateDTO>();

            try
            {
                if (!CheckUser(usserRegister))
                {
                    responseService.Date = null;
                    responseService.Mensage = "Email e user já cadastrado";
                    responseService.Status = false;
                    return responseService;
                }



            }
            catch (Exception ex)
            {
                responseService.Date = null;
                responseService.Mensage = ex.Message;
                responseService.Status = false;
            }

            return responseService;
        }

        public bool CheckUser(UserCreateDTO userRegister)
        {
            var user = _context.Users.FirstOrDefault(userDatabase => userDatabase.Email == userRegister.Email || userDatabase.User == userRegister.User);

            if (user != null) return false;
            return true;
        }
    }
}
