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
    [XafDisplayName("Nhóm Lao Động")]
    [Persistent(@"Labors")]
    [XafDefaultProperty(nameof(name))]
    public class Labors : BaseObject
    {
        public Labors(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _name;
        [XafDisplayName("Tên Nhóm Lao Động")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        string _benefits;
        [XafDisplayName("Đãi Ngộ")]
        [Size(500)]
        public string benefits
        {
            get => _benefits;
            set => SetPropertyValue(nameof(benefits), ref _benefits, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("Employee-Labor")]
        [XafDisplayName("Danh Sách Nhân Viên")]
        public XPCollection<Employees> employees { get => GetCollection<Employees>(nameof(employees)); }
    }
}
