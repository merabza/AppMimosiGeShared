using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილების გენერატორის შეცდომა (ErrorLogTexts-ის კოდი და ტექსტი). LessonDate ჯგუფის დონის შეცდომებზე (1–3)
///     ცარიელია,
///     LessonId მხოლოდ არსებული გაკვეთილის შეცდომებს აქვს (11, 14)
/// </summary>
public sealed record LessonGeneratorErrorResponse(int ErrorCode, string ErrorText, DateTime? LessonDate, int? LessonId);
