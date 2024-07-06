using AttendanceClient.Dto.StudentCourse;
using AttendanceClient.Dto.StudentSchedules;
using AttendanceClient.GrpcService;
using AttendanceClient.Service;
using AttendanceGrpcServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceClient.Pages.Attendance
{
	public class ReportModel : PageModel
	{
		private StudentCourseGrpcService studentCourseService;
		public List<StudentCourseResponse> StudentCourses { get; set; }
		public List<AttendanceGrpcServer.AttendanceDto> AttendanceDto { get; set; }
		public string Message { get; set; }
		[BindProperty(SupportsGet = true)]
		public int CourseId { get; set; }

		public ReportModel(StudentCourseGrpcService studentCourseService)
		{
			this.studentCourseService = studentCourseService;
		}

		public async Task OnGet()
		{
			await GetData();
		}

		public async Task GetData()
		{
			try
			{
				int id = Int32.Parse(User.Claims.First(claim => claim.Type == "Id").Value);
				ListStudentCourse response = await studentCourseService.ListStudentCourse(id);
				StudentCourses = response.Result.ToList();
				if (CourseId != 0)
				{
					ListStudentCourseAttenanceResponse attenanceResponse = await studentCourseService.GetStudentCourse(id, CourseId);
					AttendanceDto = attenanceResponse.Result.ToList();
					Message = attenanceResponse.Message;
				}
			}
			catch (Exception ex)
			{

				Message = ex.Message;
			}

		}
	}
}
