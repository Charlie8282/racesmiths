using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models.ViewModels
{
    public class ManageUserRolesViewModel
    {
        public RSUser User { get; set; }
        public SelectList Roles { get; set; }
        public string SelectedRole { get; set; }
    }
}
