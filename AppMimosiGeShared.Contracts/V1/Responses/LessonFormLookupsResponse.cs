using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების სიის ფილტრისა და გაკვეთილის ფორმის ცნობარები: ჯგუფები ("კოდი / სასწავლო წელი"),
///     მასწავლებლების კონტრაქტები ("გვარი სახელი / ნომერი", როგორც Access-ის ფორმაზე), გაკვეთილის სტატუსები და სიის
///     წლის ფილტრისთვის სასწავლო წლები და მიმდინარე წელი (ნაწილი 20)
/// </summary>
public sealed record LessonFormLookupsResponse(
    List<LookupItemResponse> Groups,
    List<LookupItemResponse> TeacherContracts,
    List<LookupItemResponse> LessonStatuses,
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears);
