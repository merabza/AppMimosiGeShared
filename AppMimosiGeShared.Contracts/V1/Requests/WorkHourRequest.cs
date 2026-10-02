using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     ნამუშევარი დროის ჩანაწერის შექმნის ან შეცვლის მოთხოვნა. TeacherContractId თანამშრომლის კონტრაქტია (სამუშაო
///     საათების ჯგუფით). WhStart და WhEnd თარიღი და დროა; WhEnd ცარიელია, სანამ სამუშაოს დასრულება არ დაფიქსირდება
/// </summary>
public sealed class WorkHourRequest
{
    public int TeacherContractId { get; init; }
    public DateTime WhStart { get; init; }
    public DateTime? WhEnd { get; init; }
}
