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
    [Persistent(@"FamilyRelationships")]
    [XafDefaultProperty(nameof(name))]
    [XafDisplayName("Thân Nhân")]
    public class FamilyRelationships : BaseObject
    {
        public FamilyRelationships(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Employees _employee;
        [XafDisplayName("Tên Nhân Viên")]
        [Association("FamilyRelationship-Employee")]
        public Employees employee
        {
            get => _employee;
            set => SetPropertyValue(nameof(employee), ref _employee, value);
        }
        string _name;
        [XafDisplayName("Họ Và Tên")]
        public string name
        {
            get => _name;
            set => SetPropertyValue(nameof(name), ref _name, value);
        }
        KindOfRelationship _kindOfRelationship;
        [XafDisplayName("Quan Hệ")]
        public KindOfRelationship kindOfRelationship
        {
            get => _kindOfRelationship;
            set => SetPropertyValue(nameof(kindOfRelationship), ref _kindOfRelationship, value);
        }
        string _phone;
        [XafDisplayName("Điện Thoại Liên Lạc")]
        public string phone
        {
            get => _phone;
            set => SetPropertyValue(nameof(phone), ref _phone, value);
        }
        string _address;
        [XafDisplayName("Địa Chỉ")]
        public string address
        {
            get => _address;
            set => SetPropertyValue(nameof(address), ref _address, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
    }
    public enum  KindOfRelationship
    {
        [XafDisplayName("Cha Ruột")]
        father,
        [XafDisplayName("Mẹ Ruột")]
        mother,
        [XafDisplayName("Bà")]
        grandMorther,
        [XafDisplayName("Ông")]
        grandFather,
        [XafDisplayName("Em trai")]
        youngerBrother,
        [XafDisplayName("Em gái")]
        youngerister,
        [XafDisplayName("Chị gái")]
        youngerSister,
        [XafDisplayName("Anh trai")]
        olderBrother,
        [XafDisplayName("Chị gái")]
        olderSister,
        [XafDisplayName("Bố vợ (Bố nuôi)")]
        fatherInLaw,
        [XafDisplayName("Mẹ vợ (Mẹ nuôi)")]
        motherInLaw,
        [XafDisplayName("Con trai")]
        son,
        [XafDisplayName("Con gái")]
        daughter
    }
}
