using AttendanceClient.Dto;
using AttendanceGrpcServer;
using Grpc.Net.Client;

namespace AttendanceClient.GrpcService
{
    public class UserGrpcService
    {
        private GrpcChannel channel;

        public UserGrpcService(GrpcChannel channel)
        {
            this.channel = channel;
        }

        public async Task<string> Login(AttendanceClient.Dto.User.LoginRequest request)
        {
            var client = new UserLogin.UserLoginClient(channel);
            var result = await client.LoginAsync(new LoginRequest { Email = request.Email, Password = request.Password });
            return result.Result.Token;
        }
    }
}
