using AttendanceClient.Dto.Schedule;
using AttendanceGrpcServer;
using Grpc.Net.Client;
using System.Security.Cryptography;

namespace AttendanceClient.GrpcService
{
    public class ScheduleGrpcService
    {

        private GrpcChannel channel;

        public ScheduleGrpcService(GrpcChannel channel)
        {
            this.channel = channel;
        }

        public async Task<ListScheduleResponse> GetStudentSchedule(int week, int year, int sid)
        {
            var client = new Scheduler.SchedulerClient(channel);
            ListScheduleResponse response = client.GetStudentSchedule(new ScheduleRequest { Id = sid, Week = week, Year = year });
            return response;
        }

        public async Task<ListScheduleResponse> GetTeacherSchedule(int week, int year, int tid)
        {
            var client = new Scheduler.SchedulerClient(channel);
            ListScheduleResponse response = client.GetTeacherSchedule(new ScheduleRequest { Id = tid, Week = week, Year = year });
            return response;
        }
    }
}
