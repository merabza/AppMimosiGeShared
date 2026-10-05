using System;
using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     „ახალი სასწავლო წლის" ოსტატის საწყისი მონაცემები: წლები (დაწყების რიგით), მიმდინარე წელი, ბოლო სამუშაო თვე და
///     გენერატორის ჰორიზონტი (თვეები გენერატორს ემატება, D66; ოსტატი მათ მხოლოდ აჩვენებს)
/// </summary>
public sealed record AcademicYearWizardInfoResponse(
    List<AcademicYearInfoResponse> AcademicYears,
    int? CurrentAcademicYearId,
    DateTime? LastOperationMonth,
    DateTime? HorizonEnd);
