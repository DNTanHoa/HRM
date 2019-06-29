using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Base.Security;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    [XafDisplayName("Người Dùng")]
    [XafDefaultProperty(nameof(employee))]
    [Persistent(@"SystemUsers")]
    public class SystemUsers : BaseObject, ISecurityUser,
        IAuthenticationStandardUser, IAuthenticationActiveDirectoryUser,
        ISecurityUserWithRoles, IPermissionPolicyUser, ICanInitialize
    {
        public SystemUsers(Session session) : base(session) { }

        Employees _employee;
        [XafDisplayName("Họ Tên Nhân Viên")]
        [RuleRequiredField(DefaultContexts.Save)]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        #region ISecurityUser Members
        string userName;
        [XafDisplayName("Tên Đăng Nhập")]
        [RuleRequiredField(DefaultContexts.Save)]
        [RuleUniqueValue("EmployeeUserNameIsUnique", DefaultContexts.Save,"Tên Đăng Nhập Đã Được Sử Dụng")]
        public string UserName
        {
            get => userName;
            set => SetPropertyValue(nameof(UserName), ref userName, value);
        }
        bool isActive = true;
        [XafDisplayName("Đã Được Kích Hoạt")]
        public bool IsActive
        {
            get => isActive;
            set => SetPropertyValue(nameof(IsActive), ref isActive, value);
        }
        
        #endregion
        #region IAuthenticationStandardUser Member
        bool changePasswordOnFirstLogon;
        [XafDisplayName("Đã Thay Đổi Mật Khẩu")]
        public bool ChangePasswordOnFirstLogon
        {
            get => changePasswordOnFirstLogon;
            set => SetPropertyValue(nameof(ChangePasswordOnFirstLogon), ref changePasswordOnFirstLogon, value);
        }
        private string storedPassword;
        [Browsable(false), Size(SizeAttribute.Unlimited), Persistent, SecurityBrowsable]
        [XafDisplayName("Mật Khẩu")]
        protected string StoredPassword
        {
            get => storedPassword;
            set => storedPassword = value;
        }
        public bool ComparePassword(string password)
        {
            return PasswordCryptographer.VerifyHashedPasswordDelegate(this.storedPassword, password);
        }
        public void SetPassword(string password)
        {
            this.storedPassword = PasswordCryptographer.HashPasswordDelegate(password);
            OnChanged("StoredPassword");
        }
        
        #endregion
        #region ISecurityUserWithRoles Members
        public IList<ISecurityRole> Roles
        {
            get
            {
                IList<ISecurityRole> result = new List<ISecurityRole>();
                foreach(EmployeeRole role in EmployeeRoles)
                {
                    result.Add(role);
                }
                return result;
            }
        }
        #endregion
        [Association("User-EmployeeRole")]
        [RuleRequiredField("EmployeeRoleIsRequired", DefaultContexts.Save,
        TargetCriteria = "IsActive",
        CustomMessageTemplate = "Tài Khoản Kích Hoạt Phải Có Ít Nhât Một Phân Quyền")]
        public XPCollection<EmployeeRole> EmployeeRoles { get => GetCollection<EmployeeRole>(nameof(EmployeeRoles)); }
        #region IPermissionPolicyUser Members
        IEnumerable<IPermissionPolicyRole> IPermissionPolicyUser.Roles
        {
            get => EmployeeRoles.OfType<IPermissionPolicyRole>();
        } 
        #endregion
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        #region ICanInitialize Members
        public void Initialize(IObjectSpace objectSpace, SecurityStrategyComplex security)
        {
            EmployeeRole newUserRole = (EmployeeRole)objectSpace.FindObject<EmployeeRole>(
            new BinaryOperator("Name", security.NewUserRoleName));
            if (newUserRole == null)
            {
                newUserRole = objectSpace.CreateObject<EmployeeRole>();
                newUserRole.Name = security.NewUserRoleName;
                newUserRole.IsAdministrative = true;
                newUserRole.users.Add(this);
            }
        }
        #endregion
        #region IPermissionPolicyUser Members
        #endregion
    }
}
