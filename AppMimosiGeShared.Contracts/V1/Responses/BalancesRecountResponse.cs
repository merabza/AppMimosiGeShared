namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     ბალანსების გადაანგარიშების შედეგი: ჯერ ჯგუფების გაკვეთილები (გენერატორი), შემდეგ კონტრაქტების შემდეგი გადახდის
///     თარიღები. GroupsCount: შემოწმებული ჯგუფები, ChangedGroupsCount: მათგან, რომელთა გაკვეთილები ან მოსწავლეების
///     სტრიქონები შეიცვალა, GroupErrorsCount: გენერატორის შეცდომები (ჟურნალშია). StudentContractsCount: გადათვლილი
///     კონტრაქტები, ChangedNextPayDatesCount: მათგან, რომელთა შემდეგი გადახდის თარიღი შეიცვალა
/// </summary>
public sealed record BalancesRecountResponse(
    int GroupsCount,
    int ChangedGroupsCount,
    int GroupErrorsCount,
    int StudentContractsCount,
    int ChangedNextPayDatesCount);
