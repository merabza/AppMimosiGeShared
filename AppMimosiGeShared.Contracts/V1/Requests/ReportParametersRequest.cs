using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     რეპორტის პარამეტრები ბმულიდან. თარიღები დღეებია; რომელი პარამეტრი სჭირდება რეპორტს, კატალოგში წერია,
///     დანარჩენი არ გამოიყენება
/// </summary>
public sealed record ReportParametersRequest(
    DateTime? StartDate,
    DateTime? EndDate,
    int? TeacherId,
    int? CourseId,
    int? StudentId);
