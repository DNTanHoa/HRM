using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    [Persistent(@"Shifts")]
    [XafDisplayName("Ca Làm Việc")]
    [XafDefaultProperty(nameof(nameOfShift))]
    public class Shifts : BaseObject
    {
        public Shifts(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _nameOfShift;
        [XafDisplayName("Tên Ca Làm Việc")]
        public string nameOfShift
        {
            get => _nameOfShift;
            set => SetPropertyValue(nameof(nameOfShift), ref _nameOfShift, value);
        }
        string _codeOfShift;
        [XafDisplayName("Mã Ca Làm Việc")]
        public string codeOfShift
        {
            get => _codeOfShift;
            set => SetPropertyValue(nameof(nameOfShift), ref _codeOfShift, value);
        }
        TimeSpan _timeIn;
        [ModelDefault("DisplayFormat", "{0:HH\\:mm}")]
        [ModelDefault("EditMask", @"HH:mm")]
        [ModelDefault("EditMaskType", "DateTime")]
        [XafDisplayName("Thời Gian Vào")]
        public TimeSpan timeIn
        {
            get => _timeIn;
            set => SetPropertyValue(nameof(timeIn), ref _timeIn, value);
        }
        TimeSpan _timeOut;
        [XafDisplayName("Thời Gian Ra")]
        [ModelDefault("EditMaskType", "DateTime")]
        [ModelDefault("DisplayFormat", "{0:HH\\:mm}")]
        [ModelDefault("EditMask", @"HH:mm")]
        public TimeSpan timeOut
        {
            get => _timeOut;
            set => SetPropertyValue(nameof(timeOut), ref _timeOut, value);
        }
        TimeSpan _addedTime;
        [XafDisplayName("Thời Gian Cộng Thêm")]
        [ModelDefault("EditMaskType", "DateTime")]
        [ModelDefault("DisplayFormat", "{0:HH\\:mm}")]
        [ModelDefault("EditMask", @"HH:mm")]
        public TimeSpan addedTime
        {
            get => _addedTime;
            set => SetPropertyValue(nameof(addedTime), ref _addedTime, value);
        }
        double _multiplier;
        [XafDisplayName("Hệ Số Nhân")]
        public double multiplier
        {
            get => _multiplier;
            set => SetPropertyValue(nameof(multiplier), ref _multiplier, value);
        }
        bool _isOvernight;
        [XafDisplayName("Có Qua Đêm")]
        public bool isOvernight
        {
            get => _isOvernight;
            set => SetPropertyValue(nameof(isOvernight), ref _isOvernight, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("Employee-Shift")]
        [XafDisplayName("Danh Sách Nhân Viên")]
        public XPCollection<Employees> employees { get => GetCollection<Employees>(nameof(employees)); }
    }
}
