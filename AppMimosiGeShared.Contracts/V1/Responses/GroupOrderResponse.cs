using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი ბრძანება რედაქტირებისთვის, ხაზებით. ნომერი, გამოცემის თარიღი, ორგანიზაცია, ხელმომწერი და ცვლილების ველები
///     მხოლოდ საჩვენებელია. GroupCode, CourseId, GroupSizeId, StudentStatusId და VoidDate ჯგუფის ველებია: მათ მხოლოდ
///     საწყისი და შექმნის ბრძანება შეიცავს (VoidDate მხოლოდ საწყისი)
/// </summary>
public sealed record GroupOrderResponse(
    int Id,
    int OrderType,
    string? Number,
    DateTime? IssueDate,
    DateTime OrderDate,
    bool IsPaused,
    int AcademicYearId,
    int? GroupId,
    int? TargetGroupId,
    string? GroupCode,
    int? CourseId,
    int? GroupSizeId,
    int? StudentStatusId,
    DateTime? VoidDate,
    string? OrganizationName,
    string? SignerTitle,
    string? SignerName,
    string CreatedByUserName,
    DateTime CreatedAt,
    string? ChangedByUserName,
    DateTime? ChangedAt,
    List<GroupOrderTeacherResponse> Teachers,
    List<GroupOrderStudentResponse> Students,
    List<GroupOrderDayTimePlaceResponse> DayTimePlaces);
