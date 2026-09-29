using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     კონტრაქტების სიის ერთი სტრიქონი
/// </summary>
public sealed record StudentContractRowResponse(
    int ScId,
    string ContractNumber,
    DateTime ContractDate,
    int StudentHumanId,
    string StudentName,
    int PayerHumanId,
    string PayerName,
    int AcademicYearId,
    string AcademicYearName,
    int? StudentStatusId,
    string? StudentStatusName,
    int? DesiredMonthlyPaymentDay);

/// <summary>
///     კონტრაქტების სიის ერთი გვერდი: ფილტრის შესაბამისი ჩანაწერების რაოდენობა, რეალური offset და სტრიქონები
/// </summary>
public sealed record StudentContractsRowsDataResponse(
    int AllRowsCount,
    int Offset,
    List<StudentContractRowResponse> Rows);

/// <summary>
///     ერთი კონტრაქტი რედაქტირებისთვის. NextPayDate და DirtyNextPayDate მხოლოდ საჩვენებელია
/// </summary>
public sealed record StudentContractResponse(
    int ScId,
    string ContractNumber,
    DateTime ContractDate,
    int StudentHumanId,
    string StudentName,
    int PayerHumanId,
    string PayerName,
    int AcademicYearId,
    int? StudentStatusId,
    int? DesiredMonthlyPaymentDay,
    DateTime? NextPayDate,
    bool DirtyNextPayDate,
    List<StudentContractDetailResponse> Details);

public sealed record StudentContractDetailResponse(
    int Id,
    int CourseId,
    int GroupSizeId,
    float FourWeekHours,
    decimal FourWeekFee,
    decimal OneHourFee);

/// <summary>
///     ჩამოსაშლელი სიის ერთი ელემენტი
/// </summary>
public sealed record LookupItemResponse(int Id, string Name);

/// <summary>
///     კონტრაქტის ფორმისა და სიის ფილტრის ცნობარები. CurrentAcademicYearId მიმდინარე სასწავლო წელია
///     (დღევანდელი თარიღი მის ფარგლებშია, ან ბოლო დაწყებული წელი)
/// </summary>
public sealed record StudentContractFormLookupsResponse(
    int? CurrentAcademicYearId,
    List<LookupItemResponse> AcademicYears,
    List<LookupItemResponse> StudentStatuses,
    List<LookupItemResponse> Courses,
    List<LookupItemResponse> GroupSizes);
