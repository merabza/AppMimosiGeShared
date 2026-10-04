using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტი: სტაბილური გასაღები (Access-ის ReportName, მაგ. r03RoomsAgenda), სათაური, აღწერა და პარამეტრები
/// </summary>
public sealed record ReportInfoResponse(
    string Key,
    string Title,
    string? Description,
    List<ReportParameterInfoResponse> Parameters);
