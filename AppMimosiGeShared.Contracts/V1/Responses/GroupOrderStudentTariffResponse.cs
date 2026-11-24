namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     მოსწავლის ნაგულისხმევი ტარიფი ბრძანების ხაზისთვის (D187, D218): 4 კვირის საათები, 4 კვირის გადასახადი, საათის
///     ფასი და კოეფიციენტი. 4 კვირის საათებს შენახვისას ფორმულა იძლევა, ამიტომ თუ ისინი ფორმულისას არ უდრის, რედაქტორი
///     საათებს ფორმულით ცვლის და გადასახადს გადაითვლის
/// </summary>
public sealed record GroupOrderStudentTariffResponse(
    int StudentContractId,
    float FourWeekHours,
    decimal FourWeekFee,
    decimal OneHourFee,
    float HoursCoefficient);
