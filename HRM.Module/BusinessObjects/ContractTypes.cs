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
    [Persistent(@"ContractTypes")]
    [XafDisplayName("Loại Hợp Đồng")]
    [XafDefaultProperty(nameof(name))]
    public class ContractTypes : BaseObject
    {
        public ContractTypes(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _name;
        [XafDisplayName("Tên Loại Hợp Đồng")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        KindOfContract _kindOfContract;
        [XafDisplayName("Loại Thời Hạn")]
        public KindOfContract kindOfContract
        {
            get => _kindOfContract;
            set => SetPropertyValue(nameof(kindOfContract), ref _kindOfContract, value);
        }
        int? _duration;
        [XafDisplayName("Thời Hạn Hợp Đồng (Tháng)")]
        public int? duration
        {
            get => _duration;
            set => SetPropertyValue(nameof(duration), ref _duration, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
    public enum KindOfContract
    {
        [XafDisplayName("Có Thời Hạn")]
        finite,
        [XafDisplayName("Vô Thời Hạn")]
        infinite
    }
}
