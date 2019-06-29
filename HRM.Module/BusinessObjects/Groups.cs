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
    [Persistent(@"Groups")]
    [XafDisplayName("Tổ Làm Việc")]
    [XafDefaultProperty(nameof(nameOfGroup))]
    public class Groups : BaseObject
    {
        public Groups(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _nameOfGroup;
        [XafDisplayName("Tên Nhóm")]
        public string nameOfGroup
        {
            get => _nameOfGroup;
            set => SetPropertyValue(nameof(nameOfGroup), ref _nameOfGroup, value);
        }
        string _codeOfGroup;
        [XafDisplayName("Mã Tổ")]
        public string codeOfGroup
        {
            get => _codeOfGroup;
            set => SetPropertyValue(nameof(codeOfGroup), ref _codeOfGroup, value);
        }
        Employees _manager;
        [XafDisplayName("Người Quản Lý")]
        public Employees manager
        {
            get => _manager;
            set => SetPropertyValue(nameof(manager), ref _manager, value);
        }
        Departments _department;
        [Association("Group-Department")]
        [XafDisplayName("Bộ Phận")]
        public Departments department
        {
            get => _department;
            set => SetPropertyValue(nameof(department), ref _department, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("Employee-Group")]
        [XafDisplayName("Danh Sách Nhân Viên")]
        public XPCollection<Employees> employees { get => GetCollection<Employees>(nameof(employees)); }
    }
}
