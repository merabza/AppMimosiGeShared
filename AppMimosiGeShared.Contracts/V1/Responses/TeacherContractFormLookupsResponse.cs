using System.Collections.Generic;

namespace AppMimosiGeShared.Contracts.V1.Responses;

/// <summary>
///     თანამშრომლის კონტრაქტის ფორმის ცნობარები
/// </summary>
public sealed record TeacherContractFormLookupsResponse(
    List<LookupItemResponse> RsQuoteTypes,
    List<LookupItemResponse> RsCountries,
    List<LookupItemResponse> SalarySchemes,
    List<LookupItemResponse> WorkHourGroups);
