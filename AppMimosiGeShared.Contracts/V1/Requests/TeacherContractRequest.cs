using System;

namespace AppMimosiGeShared.Contracts.V1.Requests;

/// <summary>
///     თანამშრომლის (მასწავლებლის, ადმინისტრაციის წევრის) კონტრაქტის შექმნის ან შეცვლის მოთხოვნა.
///     სამუშაოს დაწყებისა და დასრულების მხოლოდ დრო მოდის, ბაზაში კი 1899-12-30-ის თარიღით ინახება
/// </summary>
public sealed class TeacherContractRequest
{
    public string? ContractNumber { get; init; }
    public DateTime ContractDate { get; init; }
    public int TeacherHumanId { get; init; }
    public string? BankAccount { get; init; }
    public string? BankAccountCode { get; init; }
    public bool PensionScheme { get; init; }
    public bool IndEnt { get; init; }
    public int? RsQuoteTypeId { get; init; }
    public int RsCountryId { get; init; }
    public decimal FixedAmount { get; init; }
    public bool NextMonth { get; init; }
    public string? Description { get; init; }
    public int? SalarySchemaByHoursId { get; init; }
    public int? WorkHourGroupId { get; init; }
    public TimeOnly? WorkHoursStart { get; init; }
    public TimeOnly? WorkHoursEnd { get; init; }
    public DateTime? ContractEndDate { get; init; }
}
