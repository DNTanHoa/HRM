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
    [Persistent(@"Positions")]
    [XafDisplayName("Chức Vụ")]
    [XafDefaultProperty(nameof(name))]
    public class Positions : BaseObject
    {
        public Positions(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _name;
        [XafDisplayName("Tên Chức Vụ")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        string _code;
        [XafDisplayName("Mã Chức Vụ")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }
        string _detail;
        [XafDisplayName("Chi Tiết Công Việc")]
        [Size(500)]
        public string detail
        {
            get => _detail;
            set => SetPropertyValue(nameof(detail), ref _detail, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("Employee-Position")]
        [XafDisplayName("Danh Sách Nhân Viên")]
        public XPCollection<Employees> emmployees { get => GetCollection<Employees>(nameof(emmployees)); }
        [Association("Candidate-Position")]
        [XafDisplayName("Danh Sách Ứng Viên")]
        public XPCollection<Candidates> candidates { get => GetCollection<Candidates>(nameof(candidates)); }
    }
}
