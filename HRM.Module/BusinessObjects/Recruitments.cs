using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Validation;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;

namespace HRM.Module.BusinessObjects
{
    [Persistent(@"Recruitments")]
    [XafDisplayName("Tuyển Dụng")]
    [XafDefaultProperty(nameof(title))]
    [DefaultClassOptions]
    public class Recruitments : BaseObject
    {
        public Recruitments(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        string _title;
        [XafDisplayName("Tiêu Đề Tuyển Dụng")]
        public string title
        {
            get => _title;
            set => SetPropertyValue(nameof(title), ref _title, value);
        }
        Positions _position;
        [XafDisplayName("Vị Trí")]
        public Positions position
        {
            get => _position;
            set => SetPropertyValue(nameof(position), ref _position, value);
        }
        string _jobDescription;
        [XafDisplayName("Mô Tả Công Việc")]
        [Size(500)]
        public string jobDescription
        {
            get => _jobDescription;
            set => SetPropertyValue(nameof(jobDescription), ref _jobDescription, value);
        }
        string _requirement;
        [XafDisplayName("Yêu Cầu")]
        [Size(500)]
        public string requirement
        {
            get => _requirement;
            set => SetPropertyValue(nameof(requirement), ref _requirement, value);
        }
        int? _requireAmount;
        [XafDisplayName("Số Lượng Yêu Cầu")]
        [RuleRequiredField(DefaultContexts.Save)]
        public int? requireAmount
        {
            get => _requireAmount;
            set => SetPropertyValue(nameof(requireAmount), ref _requireAmount, value);
        }
        [XafDisplayName("Số Lượng Đã Tuyển")]
        public int? passedAmount
        {
            get => this.candidates.Where(candidate => candidate.candidateStatus == CandidateStatus.passed).Count();
        }
        DateTime _deadline;
        [XafDisplayName("Hạn Chót")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime deadline
        {
            get => _deadline;
            set => SetPropertyValue(nameof(deadline), ref _deadline, value);
        }
        string _note;
        [XafDisplayName("Ghi Chú")]
        public string note
        {
            get => _note;
            set => SetPropertyValue(nameof(note), ref _note, value);
        }
        [Association(@"Candidate-Recruitment")]
        [XafDisplayName("Danh Sách Ứng Viên")]
        public XPCollection<Candidates> candidates { get => GetCollection<Candidates>(nameof(candidates)); }
    }
}
