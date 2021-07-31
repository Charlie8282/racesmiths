using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Models.ViewModels
{
    public class ManageClubUsersViewModel
    {
        public Club Club { get; set; }
        public MultiSelectList Users { get; set; }  //populates list box
        public string[] SelectedUsers { get; set; }  // recieves selected users
    }
}
