using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     უწყისი მდგენელებით, სტრიქონებით და სტრიქონების დეტალებით (ჯგუფების მიხედვით)
/// </summary>
public sealed record SalaryHeaderResponse(
    int ShId,
    DateTime ShChargeDate,
    DateTime ShTransferDate,
    List<SalaryPartResponse> Parts,
    List<SalaryLineResponse> Lines,
    List<SalaryLineDetailResponse> Details);

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

/// <summary>
///     უწყისის სტრიქონი (გამოთვლის შედეგი, მხოლოდ საჩვენებელი)
/// </summary>
public sealed record SalaryLineResponse(
    int SaId,
    int TeacherContractId,
    string EmployeeName,
    decimal SaNetAmountRound,
    decimal SaAmountGross,
    decimal SaPension2,
    decimal SaGrossMinusPension,
    decimal SaIncomeTax,
    decimal SaGamokvitva,
    decimal SaPension4,
    decimal SaAmountNet,
    DateTime SaMonthDate,
    int? RsQuoteTypeId,
    decimal SaIndividualIncomeTax);

/// <summary>
///     სტრიქონის დეტალი ჯგუფის მიხედვით: ჯგუფის თანხა, საათები და ერთი საათის ღირებულება
/// </summary>
public sealed record SalaryLineDetailResponse(
    int SadId,
    int SaId,
    string EmployeeName,
    int GroupId,
    string GroupCode,
    float SadHoursCount,
    decimal SadAmount,
    decimal SadHourCost);
