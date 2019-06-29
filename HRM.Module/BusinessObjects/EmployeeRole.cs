using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    public class EmployeeRole : PermissionPolicyRoleBase, IPermissionPolicyRoleWithUsers
    {
        public EmployeeRole(Session session) : base(session) { }
        [Association("User-EmployeeRole")]
        public XPCollection<SystemUsers> users { get => GetCollection<SystemUsers>(nameof(users)); }
        public IEnumerable<IPermissionPolicyUser> Users
        {
            get => Users.OfType<IPermissionPolicyUser>();
        }
    }
}
