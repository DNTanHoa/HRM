using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    [Persistent(@"Vacations")]
    [XafDisplayName("Lần Nghỉ")]
    public class Vacations : BaseObject
    {
        public Vacations(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.createDate = DateTime.Today;
        }
        Employees _restEmployee;
        [XafDisplayName("Người Nghỉ")]
        [Association("Employee-Vacations")]
        public Employees restEmployee
        {
            get => _restEmployee;
            set => SetPropertyValue(nameof(restEmployee), ref _restEmployee, value);
        }
        DateTime _createDate;
        [XafDisplayName("Ngày Tạo")]
        [ModelDefault("EditMask","false")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime createDate
        {
            get => _createDate;
            set => SetPropertyValue(nameof(createDate), ref _createDate, value);
        }
        DateTime _restDate;
        [XafDisplayName("Ngày Nghỉ")]
        [ModelDefault("DisplayFormat","{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime restDate
        {
            get => _restDate;
            set => SetPropertyValue(nameof(restDate), ref _restDate, value);
        }
        VacationType _type;
        [XafDisplayName("Loại Nghỉ")]
        public VacationType type
        {
            get => _type;
            set => SetPropertyValue(nameof(type), ref _type, value);
        }
        string _reason;
        [XafDisplayName("Lý Do")]
        [RuleRequiredField(DefaultContexts.Save,TargetCriteria = "[Loại Nghỉ] = 'allowed'")]
        public string reason
        {
            get => _reason;
            set => SetPropertyValue(nameof(reason), ref _reason, value);
        }
        Employees _approveEmployee;
        [XafDisplayName("Người Duyệt")]
        [ModelDefault("AllowEdit","false")]
        public Employees approveEmployee
        {
            get => _approveEmployee;
            set => SetPropertyValue(nameof(approveEmployee), ref _approveEmployee, value);
        }
        DateTime _approveDate;
        [XafDisplayName("Ngày Duyệt")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        [ModelDefault("AllowEdit", "false")]
        public DateTime approveDate
        {
            get => _approveDate;
            set => SetPropertyValue(nameof(approveDate), ref _approveDate, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
    public enum VacationType
    {
        [XafDisplayName("Nghỉ Có Phép")]
        allowed,
        [XafDisplayName("Nghỉ Không Phép")]
        disallowed
    }
}
