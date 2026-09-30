using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

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
