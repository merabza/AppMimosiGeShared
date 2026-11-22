namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მასწავლებელი ბრძანების ბეჭდვისთვის: „გვარი სახელი" და ხელფასის სქემის სახელი
/// </summary>
public sealed record GroupOrderPrintTeacherResponse(string TeacherName, string SalarySchemeName);
