using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Module.BusinessObjects
{
    [Persistent(@"Employees")]
    [XafDisplayName("Nhân Viên")]
    [XafDefaultProperty(nameof(fullName))]
    [DefaultClassOptions]
    public class Employees : BaseObject
    {
        public Employees(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _fullName;
        [XafDisplayName("Họ Và Tên")]
        public string fullName
        {
            get => _fullName;
            set => SetPropertyValue(nameof(fullName), ref _fullName, value);
        }
        string _employeeCode;
        [XafDisplayName("Mã Nhân Viên")]
        public string employeeCode
        {
            get => _employeeCode;
            set => SetPropertyValue(nameof(employeeCode), ref _employeeCode, value);
        }
        string _cardCode;
        [XafDisplayName("Mã Thẻ Nhân Viên")]
        public string cardCode
        {
            get => _cardCode;
            set => SetPropertyValue(nameof(cardCode), ref _cardCode, value);
        }
        string _permanentAddress;
        [XafDisplayName("Địa Chỉ Thường Trú")]
        public string permanentAddress
        {
            get => _permanentAddress;
            set => SetPropertyValue(nameof(permanentAddress), ref _permanentAddress, value);
        }
        string _temporaryAddress;
        [XafDisplayName("Địa Chỉ Tạm Trú")]
        public string temporaryAddress
        {
            get => _temporaryAddress;
            set => SetPropertyValue(nameof(temporaryAddress), ref _temporaryAddress, value);
        }
        string _phoneNumber;
        [XafDisplayName("Điện Thoại")]
        public string phoneNumber
        {
            get => _phoneNumber;
            set => SetPropertyValue(nameof(phoneNumber), ref _phoneNumber, value);
        }
        string _email;
        [XafDisplayName("Email Liên Lạc")]
        [Appearance("Email", Context = "Any", FontColor = "Blue", FontStyle = System.Drawing.FontStyle.Underline, TargetItems = nameof(email))]
        public string email
        {
            get => _email;
            set => SetPropertyValue(nameof(email), ref _email, value);
        }
        RelationshipStatus _relationshipStatus;
        [XafDisplayName("Tình Trạng Gia Đình")]
        public RelationshipStatus relationshipStatus
        {
            get => _relationshipStatus;
            set => SetPropertyValue("relationshipStatus", ref _relationshipStatus, value);
        }
        Gender _gender;
        [XafDisplayName("Giới Tính")]
        public Gender gender
        {
            get => _gender;
            set => SetPropertyValue(nameof(gender), ref _gender, value);
        }
        string _health;
        [XafDisplayName("Sức Khỏe")]
        public string health
        {
            get => _health;
            set => SetPropertyValue(nameof(health), ref _health, value);
        }
        [NonPersistent]
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        public string contentOfPhoto
        {
            get => this.photo != null ? Convert.ToBase64String(this.photo) : null;
            set => this.photo = Convert.FromBase64String(value);
        }
        byte[] _photo;
        [XafDisplayName("Hình Ảnh")]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit,
        DetailViewImageEditorMode = ImageEditorMode.PictureEdit,
        ListViewImageEditorCustomHeight = 50)]
        public byte[] photo
        {
            get => _photo;
            set => SetPropertyValue(nameof(photo), ref _photo, value);
        }
        DateTime _dateOfBirth;
        [XafDisplayName("Ngày Sinh")]
        [ModelDefault("DisplayFormat","{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime dateOfBirth
        {
            get => _dateOfBirth;
            set => SetPropertyValue(nameof(dateOfBirth), ref _dateOfBirth, value);
        }
        string _religion;
        [XafDisplayName("Tôn Giáo")]
        public string religion
        {
            get => _religion;
            set => SetPropertyValue(nameof(religion), ref _religion, value);
        }
        string _countryside;
        [XafDisplayName("Nguyên Quán")]
        public string countryside
        {
            get => _countryside;
            set => SetPropertyValue(nameof(countryside), ref _countryside, value);
        }
        Departments _department;
        [XafDisplayName("Bộ Phận")]
        [Association("Employee-Department")]
        public Departments department
        {
            get => _department;
            set => SetPropertyValue(nameof(department), ref _department, value);
        }
        Groups _group;
        [XafDisplayName("Tổ")]
        [Association("Employee-Group")]
        public Groups group
        {
            get => _group;
            set => SetPropertyValue(nameof(group), ref _group, value);
        }
        Labors _labor;
        [XafDisplayName("Nhóm Lao Động")]
        [Association("Employee-Labor")]
        public Labors labor
        {
            get => _labor;
            set => SetPropertyValue(nameof(labor), ref _labor, value);
        }
        Positions _position;
        [XafDisplayName("Chức Vụ")]
        [Association("Employee-Position")]
        public Positions position
        {
            get => _position;
            set => SetPropertyValue(nameof(position), ref _position, value);
        }
        Shifts _shift;
        [XafDisplayName("Ca Làm Việc")]
        [Association("Employee-Shift")]
        public Shifts shift
        {
            get => _shift;
            set => SetPropertyValue(nameof(shift), ref _shift, value);
        }
        [XafDisplayName("Ngày Bắt Đầu")]
        public DateTime? startDate
        {
            get => this.contracts.LastOrDefault() != null ? (DateTime?)(this.contracts.LastOrDefault().startDate) : null;
        }
        [XafDisplayName("Lương Cơ Bản")]
        public double? salary
        {
            get => this.contracts.LastOrDefault() != null ? this.contracts.LastOrDefault().salary : null;
        }
        [XafDisplayName("Số Ngày Phép")]
        public double vacation
        {
            get => this.contracts.LastOrDefault() != null ? this.contracts.LastOrDefault().vacation : 0;
        }
        [XafDisplayName("Thâm Niên (Năm)")]
        public int seniority
        {
            get => this.startDate != null ? (int)(DateTime.Today.Year - ((DateTime)this.startDate).Year) : 0;
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association("FamilyRelationship-Employee")]
        [XafDisplayName("Quan Hệ Gia Đình")]
        public XPCollection<FamilyRelationships> familyRelationships { get => GetCollection<FamilyRelationships>(nameof(familyRelationships)); }
        [Association("Contract-Employee")]
        [XafDisplayName("Hợp Đồng Lao Động")]
        public XPCollection<Contracts> contracts { get => GetCollection<Contracts>(nameof(contracts)); }
        [Association("Idetification-Employee")]
        [XafDisplayName("Giấy Tờ Tùy Thân")]
        public XPCollection<Identifications> identifications { get => GetCollection<Identifications>(nameof(identifications)); }
        [Association(@"Degree-Employee")]
        [XafDisplayName("Bằng Cấp")]
        public XPCollection<Degrees> degrees { get => GetCollection<Degrees>(nameof(degrees)); }
        [Association("Decision-Employee")]
        [XafDisplayName("Khen Thưởng / Kỷ Luật")]
        public XPCollection<Decisions> decisions { get => GetCollection<Decisions>(nameof(decisions)); }
        [Association(@"Overtime-Employee")]
        [XafDisplayName("Lần Tăng Ca")]
        public XPCollection<OverTimes> overtimes { get => GetCollection<OverTimes>(nameof(overtimes)); }
        [Association("Employee-Vacations")]
        [XafDisplayName("Các Lần Nghỉ")]
        public XPCollection<Vacations> vacations { get => GetCollection<Vacations>(nameof(vacations)); }
    }
    public enum RelationshipStatus
    {
        [XafDisplayName("Độc Thân")]
        alone,
        [XafDisplayName("Đã Kết Hôn")]
        married,
        [XafDisplayName("Đã Ly Hôn")]
        divorced,
    }
    public enum Gender
    {
        [XafDisplayName("Nam")]
        male,
        [XafDisplayName("Nữ")]
        female,
        [XafDisplayName("Không Xác Định")]
        unknown
    }
}
