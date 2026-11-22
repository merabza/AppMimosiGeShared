using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანების ფორმისა და სიის ფილტრის ცნობარები (GroupOrdersRoute.FormLookups). სიები ჯგუფის ფორმისას იმეორებს,
///     რადგან ბრძანებების გვერდს მხოლოდ თავისი უფლება სჭირდება. მოთხოვნის პარამეტრებზე დამოკიდებული ნაწილი:
///     Groups და StudentContracts: სასწავლო წლის ჯგუფები და კონტრაქტები (ტარიფებით, ნაგულისხმევი ტარიფისთვის, D187);
///     Group და TargetGroup: მოთხოვნილი ჯგუფისა (2–10) და გადაყვანის სამიზნე ჯგუფის (5) მდგომარეობა ბრძანების თარიღზე;
///     SuggestedGroupCode: შექმნის ბრძანების კოდის შეთავაზება წლისა და სტატუსის მიხედვით (D186).
///     TeacherContracts-ის SalarySchemaByHoursId მასწავლებლის ნაგულისხმევი სქემაა (D187)
/// </summary>
public sealed record GroupOrderFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> Courses,
    List<LookupItemResponse> GroupSizes,
    List<LookupItemResponse> StudentStatuses,
    List<GroupTeacherContractLookupResponse> TeacherContracts,
    List<LookupItemResponse> SalarySchemes,
    List<LookupItemResponse> WeekDays,
    List<LookupItemResponse> LessonStartTimes,
    List<LookupItemResponse> Rooms,
    List<GroupOrderGroupLookupResponse> Groups,
    List<GroupStudentContractLookupResponse> StudentContracts,
    GroupOrderGroupStateResponse? Group,
    GroupOrderGroupStateResponse? TargetGroup,
    string? SuggestedGroupCode);
