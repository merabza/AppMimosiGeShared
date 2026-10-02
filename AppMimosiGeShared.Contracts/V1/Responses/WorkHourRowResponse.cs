using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ნამუშევარი დროის სიის ერთი სტრიქონი. EmployeeName "გვარი სახელი / ნომერი"-ა, როგორც Access-ის ფორმის ჩამოსაშლელ
///     სიაში. Hours ხანგრძლივობაა საათებში (2 ათწილადით); დაუსრულებელ ჩანაწერზე null
/// </summary>
public sealed record WorkHourRowResponse(
    int Id,
    int TeacherContractId,
    string EmployeeName,
    DateTime WhStart,
    DateTime? WhEnd,
    decimal? Hours);
