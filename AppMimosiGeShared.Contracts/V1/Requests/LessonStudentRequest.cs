namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     გაკვეთილზე მოსწავლის სტრიქონის (LessonsByStudents) რედაქტირებადი ველები. ცარიელი ტექსტი NULL-ად ინახება
/// </summary>
public sealed class LessonStudentRequest
{
    public int Id { get; init; }
    public bool Present { get; init; }
    public string? Theme { get; init; }
    public float? Rate { get; init; }
    public string? TeacherComment { get; init; }
    public string? StudentComment { get; init; }
    public int StudentLateMinutes { get; init; }
}
