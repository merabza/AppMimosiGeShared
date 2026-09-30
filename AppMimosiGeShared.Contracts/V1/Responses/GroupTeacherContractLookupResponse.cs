namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მასწავლებლის კონტრაქტი ჯგუფის ფორმის ჩამოსაშლელ სიაში: "გვარი სახელი / კონტრაქტის ნომერი".
///     SalarySchemaByHoursId ხელფასის ძირითადი სქემაა: მასწავლებლის არჩევისას ის ჩაიწერება სქემის ველში
/// </summary>
public sealed record GroupTeacherContractLookupResponse(int Id, string Name, int? SalarySchemaByHoursId);
