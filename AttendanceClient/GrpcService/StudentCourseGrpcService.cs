using AttendanceClient.Dto.StudentCourse;
using AttendanceGrpcServer;
using Grpc.Net.Client;

namespace AttendanceClient.GrpcService
{
    public class StudentCourseGrpcService
    {
        private GrpcChannel Channel;

        public StudentCourseGrpcService(GrpcChannel channel)
        {
            Channel = channel;
        }

        public async Task<ListStudentCourse> ListStudentCourse(int id)
        {
            var client = new StudentCourser.StudentCourserClient(Channel);
            ListStudentCourse response = await client.GetListStudentCourseAsync(new StudentCourseRequest { Id = id });
            return response;
        }

        public async Task<ListStudentCourseAttenanceResponse> GetStudentCourse(int sid, int cid)
        {
            var client = new Scheduler.SchedulerClient(Channel);
            ListStudentCourseAttenanceResponse response = await client.GetStudentCourseAttendanceAsync(new StudentCourseAttenaceRequest { Cid = cid, Sid = sid });
            return response;
        }
    }
}
