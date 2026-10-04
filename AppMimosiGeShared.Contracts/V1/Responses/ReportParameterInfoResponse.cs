namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტის პარამეტრი: Name ReportParameterNames-იდანაა, Caption ფილტრის წარწერაა
/// </summary>
public sealed record ReportParameterInfoResponse(string Name, string Caption, bool Required);
