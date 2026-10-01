using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების გენერატორის ლოგის სტრიქონი (LessonsCheckCreateErrorLogs + ErrorLogTexts). ლოგში ყოველი ჯგუფის მხოლოდ
///     ბოლო გენერაციის შეცდომებია: გენერაცია ჯგუფის ძველ ჩანაწერებს შლის
/// </summary>
public sealed record LessonGeneratorLogRowResponse(
    int Id,
    DateTime CreatedDate,
    int GrpId,
    string GroupCode,
    int ErrorCode,
    string ErrorText,
    DateTime? LessonDate,
    int? LessonId);
