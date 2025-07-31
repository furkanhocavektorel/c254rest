using Microsoft.AspNetCore.Mvc;
using obs.config;
using obs.dto.request;
using obs.service.abstracts;

namespace obs.Controllers
{
    [Route(EndPoints.TeacherBase)] // api/v1/teacher
    [ApiController]
    public class TeacherController
    {
        ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        [HttpPost("assign-branch")]
        public void assignBranch([FromBody] AssignBranchRequestDto dto)
        {
            teacherService.assignBranch(dto);
        }




    }
}
