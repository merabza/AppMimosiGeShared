using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ჯგუფის „ბოლო გაკვეთილი" (Access-ის CheckLastLesson): დღეს ან მის წინ ბოლო დღის გაკვეთილი, რომელიც უნდა არსებობდეს.
///     ის საჭიროებისას იქმნება ან სწორდება. LessonId ცარიელია, თუ ასეთი დღე ჯგუფის დაწყებიდან დღემდე არ არის.
///     Generation გზად გაკეთებული ცვლილებებია
/// </summary>
public sealed record GroupLastLessonResponse(int? LessonId, DateTime? LessonDt, LessonsGenerationResponse Generation);
