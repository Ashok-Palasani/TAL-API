﻿using System;
using System.Collections.Generic;

namespace DAS.DBModels
{
    public partial class Tblroles
    {
        public Tblroles()
        {
            Tbloperatordetails = new HashSet<Tbloperatordetails>();
            TblusersPrimaryRoleNavigation = new HashSet<Tblusers>();
            TblusersSecondaryRoleNavigation = new HashSet<Tblusers>();
        }

        public int RoleId { get; set; }
        public string RoleDesc { get; set; }
        public string RoleType { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Tbloperatordetails> Tbloperatordetails { get; set; }
        public virtual ICollection<Tblusers> TblusersPrimaryRoleNavigation { get; set; }
        public virtual ICollection<Tblusers> TblusersSecondaryRoleNavigation { get; set; }
    }
}
