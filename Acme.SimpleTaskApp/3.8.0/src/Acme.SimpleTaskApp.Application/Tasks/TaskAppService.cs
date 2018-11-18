using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Acme.SimpleTaskApp.Tasks.DTOs;

namespace Acme.SimpleTaskApp.Tasks
{
    public class TaskAppService : ITaskAppService
    {
        //https://aspnetboilerplate.com/Pages/Documents/Articles/Introduction-With-AspNet-Core-And-Entity-Framework-Core-Part-1/index.html#ArticleTaskAppService
        //Now, we can implement the ITaskAppService as shown below:
        public Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            throw new NotImplementedException();
        }
    }
}
