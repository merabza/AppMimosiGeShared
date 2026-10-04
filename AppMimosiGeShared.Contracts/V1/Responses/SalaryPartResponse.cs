namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ხელფასის მდგენელი. EmployeeName "გვარი სახელი / ნომერი"-ა
/// </summary>
public sealed record SalaryPartResponse(
    int SpId,
    int TeacherContractId,
    string EmployeeName,
    int? SalaryPartTypeId,
    string? SalaryPartTypeName,
    decimal SpAmount);
