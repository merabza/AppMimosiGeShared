using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანების ბეჭდვის მონაცემი (D193, GROUP_ORDERS.md §7); საწყისი ბრძანება არ იბეჭდება. ორგანიზაცია და ხელმომწერი
///     ბრძანებიდან მოდის, არა კონფიგურაციიდან, სახელები კი უკვე ამოხსნილია. ჯგუფის წელი, საგანი, ზომა და სტატუსი
///     ჯგუფის მონაცემებია (1). Previous… ველები ცვლილების ბრძანებებს აქვს: PreviousTeacher (2, 9),
///     PreviousDayTimePlaces (6, 10), მოსწავლის ძველი ტარიფი (8, 10)
/// </summary>
public sealed record GroupOrderPrintResponse(
    int Id,
    int OrderType,
    string Number,
    DateTime IssueDate,
    DateTime OrderDate,
    string OrganizationName,
    string SignerTitle,
    string SignerName,
    string GroupCode,
    string? TargetGroupCode,
    string AcademicYearName,
    string CourseName,
    string GroupSizeName,
    string StudentStatusName,
    GroupOrderPrintTeacherResponse? Teacher,
    GroupOrderPrintTeacherResponse? PreviousTeacher,
    List<GroupOrderPrintDayTimePlaceResponse> DayTimePlaces,
    List<GroupOrderPrintDayTimePlaceResponse> PreviousDayTimePlaces,
    List<GroupOrderPrintStudentResponse> Students);
