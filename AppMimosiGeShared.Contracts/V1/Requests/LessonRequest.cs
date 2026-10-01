using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     გაკვეთილის ჟურნალის შენახვა: გაკვეთილის რედაქტირებადი ველები და მოსწავლეების დასწრება და კომენტარები.
///     ჯგუფს, მასწავლებელს, დროს, სქემას და საათებს გენერატორი ადგენს, ამიტომ ისინი აქ არ არის.
///     Students-ში მხოლოდ ამ გაკვეთილის სტრიქონები მოდის; გამოტოვებული სტრიქონი არ იცვლება
/// </summary>
public sealed class LessonRequest
{
    public int LessonStatusId { get; init; }
    public int? SubstituteTeacherContractId { get; init; }
    public int TeacherLateMinutes { get; init; }
    public DateTime? RecoverDate { get; init; }
    public string? Note { get; init; }
    public List<LessonStudentRequest> Students { get; init; } = [];
}
