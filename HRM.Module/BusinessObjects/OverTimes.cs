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
    [Persistent(@"OverTimes")]
    [XafDisplayName("Lần Tăng Ca")]
    public class OverTimes : BaseObject
    {
        public OverTimes(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Employees _overtimeEmployee;
        [XafDisplayName("Người Tăng Ca")]
        [Association(@"Overtime-Employee")]
        public Employees overtimeEmployee
        {
            get => _overtimeEmployee;
            set => SetPropertyValue(nameof(overtimeEmployee), ref _overtimeEmployee, value);
        }
        DateTime _overtimeDate;
        [XafDisplayName("Ngày Tăng Ca")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime overtimeDate
        {
            get => _overtimeDate;
            set => SetPropertyValue(nameof(overtimeDate), ref _overtimeDate, value);
        }
        TimeSpan _startTime;
        [XafDisplayName("Thời Gian Bắt Đầu")]
        [ModelDefault("EditMaskType", "DateTime")]
        [ModelDefault("DisplayFormat", "{0:HH\\:mm}")]
        [ModelDefault("EditMask", @"HH:mm")]
        public TimeSpan startTime
        {
            get => _startTime;
            set => SetPropertyValue(nameof(startTime), ref _startTime, value);
        }
        TimeSpan _endTime;
        [XafDisplayName("Thời Gian Kết Thúc")]
        [ModelDefault("EditMaskType", "DateTime")]
        [ModelDefault("DisplayFormat", "{0:HH\\:mm}")]
        [ModelDefault("EditMask", @"HH:mm")]
        public TimeSpan endTime
        {
            get => _endTime;
            set => SetPropertyValue(nameof(endTime), ref _endTime, value);
        }
        string _reason;
        [XafDisplayName("Lý Do")]
        public string reason
        {
            get => _reason;
            set => SetPropertyValue(nameof(reason), ref _reason, value);
        }
        OvertimeTypes _overtimeType;
        [XafDisplayName("Loại Tăng Ca")]
        public OvertimeTypes overtimeType
        {
            get => _overtimeType;
            set => SetPropertyValue(nameof(overtimeType), ref _overtimeType, value);
        }
        [XafDisplayName("Hệ Số Nhân Giờ")]
        public double? multiplier
        {
            get => this.overtimeType != null? (double?)overtimeType.multiplier : null;
        }
        [XafDisplayName("Tổng Thời Gian")]
        public double? sumOfTime
        {
            get => this.multiplier != null ? (double?)(Math.Round((this.endTime - this.startTime).TotalMinutes / 60, 1)): null;
        }
        Employees _approver;
        [XafDisplayName("Người Duyệt")]
        [ModelDefault("AllowEdit", "false")]
        public Employees approver
        {
            get => _approver;
            set => SetPropertyValue(nameof(approver), ref _approver, value);
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
    }
}
