using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფების სიის ერთი სტრიქონი. სია სამი რეჟიმით იძებნება (Access-ის cmbFindMethod):
///     ჯგუფით: ერთი სტრიქონი ერთ ჯგუფზე, RowId = GrpId, TeacherName დღევანდელი მასწავლებელია, ActiveStudentsCount
///     დღევანდელი მოსწავლეების რაოდენობა;
///     მასწავლებლით: ერთი სტრიქონი ჯგუფის ერთ მასწავლებელზე, RowId = GroupsByTeachers.Id, StartDate/EndDate მისი პერიოდია;
///     მოსწავლით: ერთი სტრიქონი ჯგუფის ერთ მოსწავლეზე, RowId = GroupsByStudents.Id, StartDate/EndDate მისი პერიოდია
/// </summary>
public sealed record GroupRowResponse(
    int RowId,
    int GrpId,
    string GroupCode,
    string AcademicYearName,
    string CourseName,
    string GroupSizeName,
    string StudentStatusName,
    DateTime? VoidDate,
    bool DirtyLessons,
    string? TeacherName,
    int? ActiveStudentsCount,
    string? StudentName,
    DateTime? StartDate,
    DateTime? EndDate);
