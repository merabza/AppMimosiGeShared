using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ნამუშევარი დროის ერთი ჩანაწერი რედაქტირებისთვის ან დაწყების/დასრულების დაფიქსირების შედეგად.
///     EmployeeName "გვარი სახელი / ნომერი"-ა
/// </summary>
public sealed record WorkHourResponse(
    int Id,
    int TeacherContractId,
    string EmployeeName,
    DateTime WhStart,
    DateTime? WhEnd);
