using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     სამუშაო დროის ავტომატური დაგენერირება გაკვეთილებიდან (Access-ის cmdAutoGenerate) სიის ფილტრის პერიოდისთვის.
///     DateFrom და DateTo დღეებია, ორივე ჩათვლით; ჩანაწერები მხოლოდ დღევანდელ დღემდე იქმნება
/// </summary>
public sealed class WorkHoursAutoGenerateRequest
{
    public DateTime? DateFrom { get; init; }
    public DateTime? DateTo { get; init; }
}
