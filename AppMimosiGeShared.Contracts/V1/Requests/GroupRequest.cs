using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჯგუფის შექმნის ან შეცვლის მოთხოვნა მასწავლებლებთან, მოსწავლეებთან და განრიგთან ერთად.
///     "საჭიროებს გაკვეთილების დაზუსტებას" (DirtyLessons) აქ არ არის: მას სერვერი რთავს ყოველ შენახვაზე
/// </summary>
public sealed class GroupRequest
{
    public int AcademicYearId { get; init; }
    public string? GroupCode { get; init; }
    public int CourseId { get; init; }
    public int GroupSizeId { get; init; }
    public int StudentStatusId { get; init; }
    public DateTime? VoidDate { get; init; }
    public List<GroupTeacherRequest> Teachers { get; init; } = [];
    public List<GroupStudentRequest> Students { get; init; } = [];
    public List<GroupDayTimePlaceRequest> DayTimePlaces { get; init; } = [];
}
