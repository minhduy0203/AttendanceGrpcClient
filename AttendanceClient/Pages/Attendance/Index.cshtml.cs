using AttendanceClient.Dto.Schedule;
using AttendanceClient.Dto.StudentSchedules;
using AttendanceClient.GrpcService;
using AttendanceClient.Service;
using AttendanceGrpcServer;
using AttendanceMananagmentProject.Dto.StudentSchedules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AttendanceClient.Pages.Attendance
{
	public class IndexModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		public int ScheduleId { get; set; }

		public ScheduleResponse Schedule { get; set; }

		[BindProperty]
		public int[] Statuses { get; set; }

		[BindProperty]
		public int[] sid { get; set; }

		public string Message { get; set; }

		public AttendanceGrpcService attendanceService { get; set; }


		public IndexModel(AttendanceGrpcService attendanceService)
		{
			this.attendanceService = attendanceService;
		}

		public async Task OnGet()
		{
			await GetData();
		}

		public async Task OnPost()
		{
			try
			{
				StudentScheduleListDto request = new StudentScheduleListDto
				{
					Statuses = this.Statuses.Select(ss => (Status)ss).ToList(),
					StudentId = this.sid.ToList(),
					ScheduleId = this.ScheduleId
				};
				AttendanceListResponse response = await attendanceService.AttendListStudent(request);
				Message = response.Message;
				await GetData();
			}
			catch (Exception ex)
			{

				Message = "Add attendance failed";
			}

		}

		public async Task GetData()
		{
			Schedule = await attendanceService.GetScheduleAttendance(ScheduleId);
			Statuses = Schedule.StudentSchedules.Select(ss => ((int)ss.Status)).ToArray();
		}
	}
}
