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
    [Persistent(@"ContractAppendix")]
    [XafDisplayName("Phục Lục Hợp Đồng")]
    [XafDefaultProperty(nameof(name))]
    public class ContractAppendix : BaseObject
    {
        public ContractAppendix(Session session) : base (session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Contracts _contract;
        [XafDisplayName("Mã Hiệu Hợp Đồng")]
        [Association("ContractAppendix-Contract")]
        public Contracts contract
        {
            get => _contract;
            set => SetPropertyValue(nameof(contract), ref _contract, value);
        }
        string _name;
        [XafDisplayName("Tên Phụ Lục")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        FileData _file;
        [XafDisplayName("Tệp Đính Kèm")]
        public FileData file
        {
            get => _file;
            set => SetPropertyValue(nameof(file), ref _file, value);
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
