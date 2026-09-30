using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ერთი თანამშრომლის კონტრაქტი რედაქტირებისთვის
/// </summary>
public sealed record TeacherContractResponse(
    int Id,
    string ContractNumber,
    DateTime ContractDate,
    int TeacherHumanId,
    string TeacherName,
    string? BankAccount,
    string? BankAccountCode,
    bool PensionScheme,
    bool IndEnt,
    int? RsQuoteTypeId,
    int RsCountryId,
    decimal FixedAmount,
    bool NextMonth,
    string? Description,
    int? SalarySchemaByHoursId,
    int? WorkHourGroupId,
    TimeOnly? WorkHoursStart,
    TimeOnly? WorkHoursEnd,
    DateTime? ContractEndDate);
