namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     სტრიქონის დეტალი ჯგუფის მიხედვით: ჯგუფის თანხა, საათები და ერთი საათის ღირებულება
/// </summary>
public sealed record SalaryLineDetailResponse(
    int SadId,
    int SaId,
    string EmployeeName,
    int GroupId,
    string GroupCode,
    float SadHoursCount,
    decimal SadAmount,
    decimal SadHourCost);
