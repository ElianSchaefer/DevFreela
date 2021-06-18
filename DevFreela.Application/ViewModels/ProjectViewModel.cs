using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime crearedAt)
        {
            Title = title;
            CrearedAt = crearedAt;
        }

        public string Title { get; private set; }
        public DateTime CrearedAt { get; private set; }
    }
}
