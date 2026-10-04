using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     რეპორტის შედეგი. სტრიქონები სექციებადაა: დაუჯგუფებელ რეპორტს ერთი სექცია აქვს სათაურის გარეშე, დაჯგუფებულს
///     თითო ჯგუფზე ერთი (სათაურით და, საჭიროებისას, ჯამის სტრიქონით). FooterRows რეპორტის ჯამებია. უჯრის მნიშვნელობა
///     სვეტის ტიპისაა (ReportColumnTypes), ცარიელი უჯრა null-ია
/// </summary>
public sealed record ReportResponse(
    string Key,
    string Title,
    List<ReportParameterValueResponse> Parameters,
    List<ReportColumnResponse> Columns,
    List<ReportSectionResponse> Sections,
    List<List<object?>> FooterRows);
