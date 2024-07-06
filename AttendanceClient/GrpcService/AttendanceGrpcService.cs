using AttendanceClient.Dto.Schedule;
using AttendanceGrpcServer;
using AttendanceMananagmentProject.Dto.StudentSchedules;
using Grpc.Net.Client;

namespace AttendanceClient.GrpcService
{
    public class AttendanceGrpcService
    {
        private GrpcChannel Channel;

        public AttendanceGrpcService(GrpcChannel channel)
        {
            Channel = channel;
        }

        public async Task<ScheduleResponse> GetScheduleAttendance(int scheduleId)
        {
            var client = new Scheduler.SchedulerClient(Channel);
            ScheduleResponse response = await client.GetScheduleAsync(new GetScheduleRequest { Id = scheduleId });
            return response;
        }

        public async Task<AttendanceListResponse> AttendListStudent(StudentScheduleListDto request)
        {
            var client = new Attendancer.AttendancerClient(Channel);
            AttendanceListRequest grpcRequest = new AttendanceListRequest { ScheduleId = request.ScheduleId };
            grpcRequest.Statuses.AddRange(request.Statuses.Select(s => (int) s));
            grpcRequest.Sid.AddRange(request.StudentId);

            AttendanceListResponse response = await client.AttendStudentsAsync(grpcRequest);
            return response;
        }
    }
}
