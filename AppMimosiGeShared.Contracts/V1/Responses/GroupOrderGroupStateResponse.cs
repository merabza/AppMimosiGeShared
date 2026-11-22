using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფის მდგომარეობა ბრძანების თარიღზე (a): ჯგუფის ველები და a-ზე მოქმედი სტრიქონები ([StartDate, EndDate)).
///     StartDate: ჯგუფის დაწყება, ანუ საწყისი ან შექმნის ბრძანების თარიღი (D190). IsActive: ჯგუფი a-ზე მოქმედია (D200).
///     CanHaveOrders: D202. WeeklyHours: a-ზე მოქმედი განრიგის კვირის საათების ჯამი, 4 კვირის საათების ფორმულისთვის
///     (D187)
/// </summary>
public sealed record GroupOrderGroupStateResponse(
    int GrpId,
    string GroupCode,
    int AcademicYearId,
    int CourseId,
    int GroupSizeId,
    int StudentStatusId,
    DateTime? VoidDate,
    DateTime? StartDate,
    bool IsActive,
    bool CanHaveOrders,
    float WeeklyHours,
    List<GroupTeacherResponse> Teachers,
    List<GroupStudentResponse> Students,
    List<GroupDayTimePlaceResponse> DayTimePlaces);
