using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბრძანებების სიის სტრიქონი. Number: „26.15" (საწყის ბრძანებას ნომერი არ აქვს). GroupCode ჯგუფის კოდია; დაპაუზებულ
///     შექმნის ბრძანებას ჯგუფი ჯერ არ აქვს (GroupId ცარიელია), ამიტომ აქ მისი კოდია. TargetGroupCode მხოლოდ გადაყვანას
///     აქვს (5)
/// </summary>
public sealed record GroupOrderRowResponse(
    int Id,
    int OrderType,
    string? Number,
    DateTime? IssueDate,
    DateTime OrderDate,
    bool IsPaused,
    int AcademicYearId,
    string AcademicYearName,
    int? GroupId,
    string GroupCode,
    int? TargetGroupId,
    string? TargetGroupCode);
