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
    [Persistent(@"Holidays")]
    [XafDisplayName("Ngày Nghỉ Lễ")]
    [XafDefaultProperty(nameof(nameOfHoliday))]
    public class Holidays : BaseObject
    {
        public Holidays(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _nameOfHoliday;
        [XafDisplayName("Tên Ngày Lễ")]
        public string nameOfHoliday
        {
            get => _nameOfHoliday;
            set => SetPropertyValue(nameof(nameOfHoliday), ref _nameOfHoliday, value);
        }
        DateTime? _startDate;
        [XafDisplayName("Ngày Bắt Đầu Nghỉ")]
        [ModelDefault("DisplayFormat","{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask","dd/MM/yyyy")]
        public DateTime? startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }
        int _amountDate;
        [XafDisplayName("Số Lượng Ngày")]
        public int amountDate
        {
            get => _amountDate;
            set => SetPropertyValue(nameof(amountDate), ref _amountDate, value);
        }
        [XafDisplayName("Ngày Kết Thúc")]
        public DateTime? endDate
        {
            get => this.startDate != null ? (this.amountDate > 0 ? (DateTime?)((DateTime)(startDate)).AddDays(amountDate - 1) : null) : null;
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
}
