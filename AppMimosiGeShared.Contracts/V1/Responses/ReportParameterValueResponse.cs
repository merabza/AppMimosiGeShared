namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტის პარამეტრის მნიშვნელობა სათაურისთვის (მაგ. "თარიღისთვის" / "02.10.2026")
/// </summary>
public sealed record ReportParameterValueResponse(string Name, string Caption, string Value);
