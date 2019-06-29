using DevExpress.ExpressApp.DC;
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
    [Persistent(@"Bonus")]
    [XafDisplayName("Khen Thưởng / Kỷ Luật")]
    [XafDefaultProperty(nameof(title))]
    public class Decisions : BaseObject
    {
        public Decisions(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _title;
        [XafDisplayName("Nội Dung Chính")]
        public string title
        {
            get => _title;
            set => SetPropertyValue(nameof(title), ref _title, value);
        }
        DateTime _decisionDate;
        [XafDisplayName("Ngày Quyết Định")]
        public DateTime decisionDate
        {
            get => _decisionDate;
            set => SetPropertyValue(nameof(decisionDate), ref _decisionDate, value);
        }
        DateTime _executeDate;
        [XafDisplayName("Ngày Thi Hành")]
        public DateTime executeDate
        {
            get => _executeDate;
            set => SetPropertyValue(nameof(executeDate), ref _executeDate, value);
        }
        Employees _employee;
        [XafDisplayName("Tên Nhân Viên")]
        [Association("Decision-Employee")]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        string _reason;
        [XafDisplayName("Lý Do")]
        public string reason
        {
            get => _reason;
            set => SetPropertyValue(nameof(reason), ref _reason, value);
        }
        string _detail;
        [XafDisplayName("Chi Tiết")]
        public string detail
        {
            get => _detail;
            set => SetPropertyValue(nameof(detail), ref _detail, value);
        }
        Employees _decisionMaker;
        [XafDisplayName("Người Ra Quyết Định")]
        [RuleRequiredField(DefaultContexts.Save)]
        public Employees decisionMaker
        {
            get => _decisionMaker;
            set => SetPropertyValue(nameof(decisionMaker), ref _decisionMaker, value);
        }
        FileData _attach;
        [XafDisplayName("Đính Kèm")]
        public FileData attach
        {
            get => _attach;
            set => SetPropertyValue(nameof(attach), ref _attach, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
    public enum TypeOfDecision
    {
        [XafDisplayName("Khen Thưởng")]
        bonus,
        [XafDisplayName("Kỷ Luật")]
        discipline
    }
}
