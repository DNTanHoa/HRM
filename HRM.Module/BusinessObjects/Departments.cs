using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    [XafDisplayName("Bộ Phận")]
    [Persistent(@"Departments")]
    [XafDefaultProperty(nameof(name))]
    public class Departments : BaseObject
    {
        public Departments(Session session):base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _name;
        [XafDisplayName("Tên Bộ Phận")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        string _code;
        [XafDisplayName("Mã Bộ Phận")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }
        Employees _departmentHead;
        [XafDisplayName("Trưởng Bộ Phận")]
        public Employees departmentHead
        {
            get => _departmentHead;
            set => SetPropertyValue(nameof(departmentHead), ref _departmentHead, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("Group-Department")]
        [XafDisplayName("Danh Sách Tổ")]
        public XPCollection<Groups> groups { get => GetCollection<Groups>(nameof(groups)); }
        [Association("Employee-Department")]
        [XafDisplayName("Danh Sách Nhân Viên")]
        public XPCollection<Employees> emmployees { get => GetCollection<Employees>(nameof(emmployees)); }
    }
}
