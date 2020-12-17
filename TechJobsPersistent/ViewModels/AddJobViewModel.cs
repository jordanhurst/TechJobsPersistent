using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {

        public string JobName { get; set; }
        public int SelectedEmployerId { get; set; }
        public List<SelectListItem> AllEmployersList { get; set; }
        public List<Skill> Skills { get; set; }


        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            AllEmployersList = new List<SelectListItem>();

            foreach (Employer e in employers)
            {
                AllEmployersList.Add(new SelectListItem
                {
                    Text = e.Name,
                    Value = e.Id.ToString()
                });
            }

            Skills = skills;
        }
    }
}
