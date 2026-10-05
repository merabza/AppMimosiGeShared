using System;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ახალი სასწავლო წელი (dry-run-ში გეგმა, AyId ცარიელია). ContractNumberPrefix: კონტრაქტის ნომრის პრეფიქსი, წლის
///     დაწყების ბოლო ციფრი (2027 → "7"). AlreadyExists: ასეთი სახელის წელი უკვე არსებობს (შექმნა 409-ს დააბრუნებს)
/// </summary>
public sealed record NewAcademicYearResponse(
    bool DryRun,
    int? AyId,
    string AcademicYearName,
    DateTime StartDate,
    DateTime FinishDate,
    string ContractNumberPrefix,
    bool AlreadyExists);
