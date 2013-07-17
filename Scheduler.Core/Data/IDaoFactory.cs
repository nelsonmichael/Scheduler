using System.Collections.Generic;
using System.Data;
using System;
using System.Collections;
using NHibernate.Transform;
using Scheduler.Core.Domain;



namespace  Scheduler.Core.Data
{
    public interface IAssignmentProvider : IDao<Assignment, int> { }

    public interface ICongregationProvider : IDao<Congregation, int> { }

    public interface ICounselPointProvider : IDao<CounselPoint, int> { }

    public interface ILanguageProvider : IDao<Language, int> { }

    public interface IMeetingProvider : IDao<Meeting, int> { }

    public interface IMeetingChangeProvider : IDao<MeetingChange, int> { }

    public interface IMeetingChangeTypeProvider : IDao<MeetingChangeType, int> { }

    public interface IPersonProvider : IDao<Person, int> { }

    public interface ISettingProvider : IDao<Setting, int> { }

    public interface IStudentProvider : IDao<Student, int> { }

    public interface ITalkProvider : IDao<Talk, int> { }

    public interface IUnavailableStudentsProvider : IDao<UnavailableStudents, int> { }

    //public interface IStudyDao : IDao<Study, int> { Study GetFirst(); }
    //public interface ISiteDao : IDao<Site, int> { }
    //public interface ICrfDao : IDao<CrfBase, int>
    //{
    //    MedicalHistorySystemCode GetMedicalHistorySystemCodeById(int id);
    //    IList<MedicalHistorySystemCode> GetAllMedicalHistorySystemCodes();
    //}
    //public interface ISubjectDao : IDao<Subject, int>
    //{
    //    Subject Enroll(Subject subject);
    //    IList<Subject> GetForSite(Site site);
    //    IList<DisplaySubject> GetFrozen(AppUser user);
    //    IList<DisplaySubject> GetLocked(AppUser user);
    //}
    //public interface IQueryDao : IDao<Query, int> 
    //{
    //    IList<Query> GetOpenWithResponse(AppUser user);
    //    IList<Query> GetPendingResponse(AppUser user); 
    //}
    //public interface IAppUserDao : IDao<AppUser, int>
    //{
    //    IList<AppUser> GetPrincipalInvestigatorsForSite(int siteId);
    //    bool UserNameExists(string userName);
    //    AppUser GetByUserName(string userName);
    //}
    //public interface INotAvailableDao : IDao<NotAvailable, int> { }
    //public interface INoteDao : IDao<Note, int> { }
    //public interface IVisitDao : IDao<Visit, int> { }
    //public interface IMessageDao : IDao<Message, int> 
    //{
    //    IList<Message> GetAll(bool includeExpired);
    //}
    //public interface IDomainBaseDao : IDao<DomainBase, int> { }
    //public interface IEnrollmentWaiverDao : IDao<EnrollmentWaiver, int> 
    //{
    //    IList<DisplayWaiver> GetPendingWaivers(AppUser user);
    //}
    //public interface IBadPasswordAttemptDao : IDao<BadPasswordAttempt, int>
    //{
    //}
    //public interface IReportInfoDao : IDao<ReportInfo, int>
    //{
    //}
}
