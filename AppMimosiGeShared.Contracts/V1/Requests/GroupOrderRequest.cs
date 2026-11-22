using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ჯგუფის ბრძანების შექმნის ან შეცვლის მოთხოვნა (GROUP_ORDERS.md §4). რომელი ნაწილია საჭირო, ტიპზეა დამოკიდებული და
///     ამას ტიპის ვალიდატორი ამოწმებს:
///     0 (მხოლოდ შეცვლა) ჯგუფის ველები VoidDate-ით და ყველა სტრიქონი თარიღებით;
///     1 ჯგუფის ველები, მასწავლებელი, მოსწავლეები და განრიგი (მასწავლებლის ან განრიგის გარეშე დაპაუზდება);
///     2, 9 ჯგუფი და ერთი მასწავლებელი; 3, 4, 8 ჯგუფი და მოსწავლეები; 5 ჯგუფი, სამიზნე ჯგუფი და მოსწავლეები;
///     6 ჯგუფი და ახალი განრიგი; 7 მხოლოდ ჯგუფი; 10 ჯგუფი, ახალი განრიგი და მოსწავლეები.
///     ნომერს, გამოცემის თარიღს, ორგანიზაციას და ხელმომწერს სერვერი წერს პირველი შენახვისას (D192, D193)
/// </summary>
public sealed class GroupOrderRequest
{
    /// <summary>
    ///     ბრძანების ტიპი 0–10
    /// </summary>
    public int OrderType { get; init; }

    /// <summary>
    ///     ბრძანების თარიღი (a): ცვლილება ამ დღიდან მოქმედებს
    /// </summary>
    public DateTime OrderDate { get; init; }

    /// <summary>
    ///     ჯგუფი (2–10; გადაყვანისას საიდან). შექმნის ბრძანებას არ აქვს: ჯგუფს თვითონ ქმნის
    /// </summary>
    public int? GroupId { get; init; }

    /// <summary>
    ///     გადაყვანის სამიზნე ჯგუფი (მხოლოდ 5)
    /// </summary>
    public int? TargetGroupId { get; init; }

    /// <summary>
    ///     ჯგუფის სასწავლო წელი (0 და 1)
    /// </summary>
    public int? AcademicYearId { get; init; }

    /// <summary>
    ///     ჯგუფის კოდი (0 და 1)
    /// </summary>
    public string? GroupCode { get; init; }

    /// <summary>
    ///     საგანი (0 და 1)
    /// </summary>
    public int? CourseId { get; init; }

    /// <summary>
    ///     ჯგუფის ზომა (0 და 1)
    /// </summary>
    public int? GroupSizeId { get; init; }

    /// <summary>
    ///     მოსწავლის სტატუსი (0 და 1)
    /// </summary>
    public int? StudentStatusId { get; init; }

    /// <summary>
    ///     ჯგუფის გაუქმების თარიღი (მხოლოდ 0)
    /// </summary>
    public DateTime? VoidDate { get; init; }

    public List<GroupOrderTeacherRequest> Teachers { get; init; } = [];
    public List<GroupOrderStudentRequest> Students { get; init; } = [];
    public List<GroupOrderDayTimePlaceRequest> DayTimePlaces { get; init; } = [];
}
