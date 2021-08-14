using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace racesmiths.Enums
{
    public enum ChampType
    {
        [Description("Championship created by the club manager")]
        ManagerChamp,
        [Description("Championship created by a club member")]
        MemberChamp
    }
}
