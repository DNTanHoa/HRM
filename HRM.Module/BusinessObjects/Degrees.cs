using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Model;

namespace HRM.Module.BusinessObjects
{
    [Persistent(@"Degrees")]
    [XafDisplayName("Bằng Cấp")]
    [XafDefaultProperty(nameof(name))]
    public class Degrees : BaseObject
    {
        public Degrees(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _name;
        [XafDisplayName("Tên Chứng Chỉ/ Bằng Cấp")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        DateTime _licensingDate;
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        [XafDisplayName("Ngày Cấp")]
        public DateTime licensingDate
        {
            get => _licensingDate;
            set => SetPropertyValue(nameof(licensingDate), ref _licensingDate, value);
        }
        string _licensingPlace;
        [XafDisplayName("Nơi Cấp")]
        public string licensingPlace
        {
            get => _licensingPlace;
            set => SetPropertyValue(nameof(licensingPlace), ref _licensingPlace, value);
        }
        Employees _employee;
        [XafDisplayName("Tên Nhân Viên")]
        [Association(@"Degree-Employee")]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        FileData _scanFile;
        [XafDisplayName("Bản Lưu")]
        public FileData scanFile
        {
            get => _scanFile;
            set => SetPropertyValue(nameof(scanFile), ref _scanFile, value);
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
