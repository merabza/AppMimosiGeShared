using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მოსწავლის კონტრაქტი ჯგუფის ფორმის ჩამოსაშლელ სიაში: "გვარი სახელი / კონტრაქტის ნომერი" და კონტრაქტის ტარიფები.
///     კონტრაქტის არჩევისას ჯგუფის საგნისა და ზომის ტარიფი ჩაიწერება მოსწავლის სტრიქონში
/// </summary>
public sealed record GroupStudentContractLookupResponse(
    int ScId,
    string Name,
    List<StudentContractDetailResponse> Tariffs);
