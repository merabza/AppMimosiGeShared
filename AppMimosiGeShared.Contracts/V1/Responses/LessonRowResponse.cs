using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების სიის ერთი სტრიქონი. StudentsCount გაკვეთილის მოსწავლეების რაოდენობაა, PresentCount დამსწრეებისა
/// </summary>
public sealed record LessonRowResponse(
    int LessonId,
    DateTime LessonDt,
    int GrpId,
    string GroupCode,
    string CourseName,
    string TeacherName,
    string? SubstituteTeacherName,
    int LessonStatusId,
    string LessonStatusName,
    int StudentsCount,
    int PresentCount);
