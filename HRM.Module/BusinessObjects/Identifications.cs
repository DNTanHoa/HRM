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
    [Persistent(@"Identifications")]
    [XafDisplayName("Giấy Tờ Tùy Thân")]
    public class Identifications : BaseObject
    {
        public Identifications(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Employees _employee;
        [XafDisplayName("Nhân Viên")]
        [Association("Idetification-Employee")]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        string _name;
        [XafDisplayName("Tên Giấy Tờ")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        DateTime _licensingDate;
        [XafDisplayName("Ngày Cấp")]
        public DateTime licensingDate
        {
            get => _licensingDate;
            set => SetPropertyValue(nameof(licensingDate), ref _licensingDate, value);
        }
        string _licensingPosition;
        [XafDisplayName("Nơi Cấp")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public string licensingPosition
        {
            get => _licensingPosition;
            set => SetPropertyValue(nameof(licensingPosition), ref _licensingPosition, value);
        }
        string _code;
        [XafDisplayName("Mã Số")]
        public string code
        {
            get => _code;
            set => SetPropertyValue(nameof(code), ref _code, value);
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
