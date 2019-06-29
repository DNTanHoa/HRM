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
    [Persistent(@"Contracts")]
    [XafDisplayName("Hợp Đồng Lao Động")]
    [XafDefaultProperty(nameof(code))]
    public class Contracts : BaseObject
    {
        public Contracts(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Employees _employee;
        [XafDisplayName("Người Lao Động")]
        [Association("Contract-Employee")]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        string _code;
        [XafDisplayName("Số Hợp Đồng")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
        }
        DateTime _signDate;
        [XafDisplayName("Ngày Ký Hợp Đồng")]
        [ModelDefault("DisplayFormat","{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask","dd/MM/yyyy")]
        public DateTime signDate
        {
            get => _signDate;
            set => SetPropertyValue(nameof(signDate), ref _signDate, value);
        }
        Positions _position;
        [XafDisplayName("Vị Trí Công Việc")]
        public Positions position
        {
            get => _position;
            set => SetPropertyValue(nameof(position), ref _position, value);
        }
        ContractTypes _contractType;
        [XafDisplayName("Loại Hợp Đồng")]
        public ContractTypes contractType
        {
            get => _contractType;
            set => SetPropertyValue(nameof(contractType), ref _contractType, value);
        }
        [XafDisplayName("Thời Hạn")]
        public string duration
        {
            get => this.contractType != null ? (this.contractType.duration != null? this.contractType.duration.ToString() + " Tháng" : null) : null;
        }
        DateTime _startDate;
        [XafDisplayName("Ngày Hiệu Lực")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }
        [XafDisplayName("Ngày Hết Hạn")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime? endDate
        {
            get => this.contractType != null ? (this.contractType.duration != null ? (DateTime?)(startDate.AddMonths((int)contractType.duration)): null) : null;
        }
        double? _salary;
        [XafDisplayName("Lương Cơ Bản")]
        public double? salary
        {
            get => _salary;
            set => SetPropertyValue(nameof(salary), ref _salary, value);
        }
        double _insurance;
        [XafDisplayName("Mức Đóng Bảo Hiểm")]
        public double insurance
        {
            get => _insurance;
            set => SetPropertyValue(nameof(insurance), ref _insurance, value);
        }
        double _vacation;
        [XafDisplayName("Ngày Nghỉ Phép")]
        public double vacation
        {
            get => _vacation;
            set => SetPropertyValue(nameof(vacation), ref _vacation, value);
        }
        Employees _representative;
        [XafDisplayName("Người Đại Diện")]
        public Employees representative
        {
            get => _representative;
            set => SetPropertyValue(nameof(representative), ref _representative, value);
        }
        [XafDisplayName("Chức Danh")]
        public Positions title
        {
            get => this.representative != null ? this.representative.position : null; 
        }
        [Association("ContractAppendix-Contract")]
        [XafDisplayName("Phụ Lục Đính Kèm")]
        public XPCollection<ContractAppendix> contractAppendixs { get => GetCollection<ContractAppendix>(nameof(contractAppendixs)); }
    }
}
