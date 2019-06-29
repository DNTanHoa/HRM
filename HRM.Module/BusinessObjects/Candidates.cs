using DevExpress.ExpressApp.ConditionalAppearance;
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
    [Persistent(@"Candidates")]
    [XafDisplayName("Danh Sách Ứng Viên")]
    [XafDefaultProperty(nameof(fullName))]
    public class Candidates : BaseObject
    {
        public Candidates(Session session) : base(session) { }
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
        Positions _position;
        [XafDisplayName("Vị Trí Ứng Tuyển")]
        [Association("Candidate-Position")]
        public Positions position
        {
            get => _position;
            set => SetPropertyValue(nameof(position), ref _position, value);
        }
        Recruitments _recruiment;
        [XafDisplayName("Đợt Tuyển Dụng")]
        [Association(@"Candidate-Recruitment")]
        public Recruitments recruitment
        {
            get => _recruiment;
            set => SetPropertyValue(nameof(recruitment), ref _recruiment, value);
        }
        DateTime _applyDate;
        [XafDisplayName("Ngày Ứng Tuyển")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime applyDate
        {
            get => _applyDate;
            set => SetPropertyValue(nameof(applyDate), ref _applyDate, value);
        }
        FileData _resume;
        [XafDisplayName("CV")]
        public FileData resume
        {
            get => _resume;
            set => SetPropertyValue(nameof(resume), ref _resume, value);
        }
        CandidateStatus _candidateStatus;
        [XafDisplayName("Tình Trạng")]
        public CandidateStatus candidateStatus
        {
            get => _candidateStatus;
            set => SetPropertyValue(nameof(candidateStatus), ref _candidateStatus, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association(@"CandidateWorkingHistory-Candidate")]
        [XafDisplayName("Quá Trình Làm Việc")]
        public XPCollection<CandidateWorkingHistory> workingHistories { get => GetCollection<CandidateWorkingHistory>(nameof(workingHistories)); }
    }
    public enum CandidateStatus
    {
        [XafDisplayName("Đang Xử Lý")]
        processing,
        [XafDisplayName("Đậu Phỏng Vấn")]
        passed,
        [XafDisplayName("Không Phù Hợp")]
        failed,
        [XafDisplayName("Đợi Phỏng Vấn")]
        waitInterview,
        [XafDisplayName("Chờ Kiểm Tra Năng Lực")]
        waitTest
    }
}
