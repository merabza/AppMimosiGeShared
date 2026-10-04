using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტის სექცია: სათაური (დაუჯგუფებელ რეპორტში null), სტრიქონები და ჯამის სტრიქონი (თუ აქვს)
/// </summary>
public sealed record ReportSectionResponse(string? Header, List<List<object?>> Rows, List<object?>? Footer);
