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
    [Persistent(@"OvertimeTypes")]
    [XafDisplayName("Loại Tăng Ca")]
    [XafDefaultProperty(nameof(nameOfOvertime))]
    public class OvertimeTypes : BaseObject
    {
        public OvertimeTypes(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _nameOfOvertime;
        [XafDisplayName("Tên Loại Tăng Ca")]
        public string nameOfOvertime
        {
            get => _nameOfOvertime;
            set => SetPropertyValue(nameof(nameOfOvertime), ref _nameOfOvertime, value);
        }
        double _multiplier;
        [XafDisplayName("Hệ Số Nhân Giờ")]
        public double multiplier
        {
            get => _multiplier;
            set => SetPropertyValue(nameof(multiplier), ref _multiplier, value);
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
