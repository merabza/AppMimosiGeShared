namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     გაკვეთილზე მოსწავლის სტრიქონი (LessonsByStudents). მოსწავლე და საათები მხოლოდ საჩვენებელია: საათებს გენერატორი
///     ჯგუფის მოსწავლის სტრიქონიდან წერს
/// </summary>
public sealed record LessonStudentResponse(
    int Id,
    int StudentContractId,
    string StudentName,
    float HoursCount,
    bool Present,
    string? Theme,
    float? Rate,
    string? TeacherComment,
    string? StudentComment,
    int StudentLateMinutes);
