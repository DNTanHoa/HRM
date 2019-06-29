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
    [Persistent(@"CandidateWorkingHistory")]
    [XafDisplayName("Quá Trình Công Tác")]
    public class CandidateWorkingHistory : BaseObject
    {
        public CandidateWorkingHistory(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        Candidates _candidate;
        [XafDisplayName("Tên Ứng Viên")]
        [Association(@"CandidateWorkingHistory-Candidate")]
        public Candidates candidate
        {
            get => _candidate;
            set => SetPropertyValue(nameof(candidate), ref _candidate, value);
        }
        string _companyName;
        [XafDisplayName("Tên Công Ty")]
        public string companyName
        {
            get => _companyName;
            set => SetPropertyValue(nameof(companyName), ref _companyName, value);
        }
        DateTime _startDate;
        [XafDisplayName("Thời Gian Bắt Đầu")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime startDate
        {
            get => _startDate;
            set => SetPropertyValue(nameof(startDate), ref _startDate, value);
        }
        DateTime _endDate;
        [XafDisplayName("Thời Gian Kết Thúc")]
        public DateTime endDate
        {
            get => _endDate;
            set => SetPropertyValue(nameof(endDate), ref _endDate, value);
        }
        string _positon;
        [XafDisplayName("Vị Trí")]
        public string position
        {
            get => _positon;
            set => SetPropertyValue(nameof(position), ref _positon, value);
        }
        string _detail;
        [XafDisplayName("Chi Tiết Công Việc")]
        [Size(100)]
        public string detail
        {
            get => _detail;
            set => SetPropertyValue(nameof(detail), ref _detail, value);
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
