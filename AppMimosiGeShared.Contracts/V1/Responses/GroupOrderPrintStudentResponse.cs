namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მოსწავლე ბრძანების ბეჭდვისთვის: „გვარი სახელი", ტარიფი და შენიშვნა. ტარიფი გაყვანის ბრძანებაში (4) ცარიელია.
///     Previous… ძველი ტარიფია, რომელსაც ბრძანება ცვლის (8, 10)
/// </summary>
public sealed record GroupOrderPrintStudentResponse(
    string StudentName,
    float? FourWeekHours,
    decimal? OneHourFee,
    decimal? FourWeekFee,
    string? Note,
    float? PreviousFourWeekHours,
    decimal? PreviousOneHourFee,
    decimal? PreviousFourWeekFee);
