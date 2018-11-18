using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.SimpleTaskApp.Tasks.DTOs
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
