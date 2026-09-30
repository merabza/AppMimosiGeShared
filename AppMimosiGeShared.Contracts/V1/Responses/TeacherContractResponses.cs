using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     თანამშრომლების კონტრაქტების სიის ერთი სტრიქონი
/// </summary>
public sealed record TeacherContractRowResponse(
    int Id,
    string ContractNumber,
    DateTime ContractDate,
    int TeacherHumanId,
    string TeacherName,
    string? SalarySchemeName,
    bool PensionScheme,
    bool IndEnt,
    decimal FixedAmount,
    DateTime? ContractEndDate);

/// <summary>
///     თანამშრომლების კონტრაქტების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record TeacherContractsRowsDataResponse(
    int AllRowsCount,
    int Offset,
    List<TeacherContractRowResponse> Rows);

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

/// <summary>
///     თანამშრომლის კონტრაქტის ფორმის ცნობარები
/// </summary>
public sealed record TeacherContractFormLookupsResponse(
    List<LookupItemResponse> RsQuoteTypes,
    List<LookupItemResponse> RsCountries,
    List<LookupItemResponse> SalarySchemes,
    List<LookupItemResponse> WorkHourGroups);
