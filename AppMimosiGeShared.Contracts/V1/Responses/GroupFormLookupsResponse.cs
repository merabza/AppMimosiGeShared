using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფის ფორმისა და სიის ფილტრის ცნობარები. CurrentAcademicYearId მიმდინარე სასწავლო წელია.
///     მოსწავლეების კონტრაქტები აქ არ არის: ისინი წლის მიხედვით ცალკე მოდის (GroupsRoute.StudentContracts)
/// </summary>
public sealed record GroupFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> Courses,
    List<LookupItemResponse> GroupSizes,
    List<LookupItemResponse> StudentStatuses,
    List<GroupTeacherContractLookupResponse> TeacherContracts,
    List<LookupItemResponse> SalarySchemes,
    List<LookupItemResponse> WeekDays,
    List<LookupItemResponse> LessonStartTimes,
    List<LookupItemResponse> Rooms);
