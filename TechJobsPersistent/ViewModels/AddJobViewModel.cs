using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        public string JobName { get; set; }
        public int SelectedEmployerId { get; set; }
        public List<SelectListItem> AllEmployersList { get; set; }


        public AddJobViewModel()
        {
        }
    }
}
