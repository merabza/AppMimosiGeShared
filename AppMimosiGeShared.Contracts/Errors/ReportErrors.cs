using SystemTools.SharedKernel;

namespace AppMimosiGeShared.Contracts.Errors;

public static class ReportErrors
{
    public static Error ReportNotFound => Error.NotFound(nameof(ReportNotFound), "რეპორტი ვერ მოიძებნა");

    public static Error PeriodIsInvalid =>
        Error.Problem(nameof(PeriodIsInvalid), "„თარიღიდან\" „თარიღამდე\"-ზე გვიან არ უნდა იყოს");

    //caption ფილტრის წარწერაა, მაგ. "თარიღისთვის"
    public static Error ParameterIsRequired(string caption)
    {
        return Error.Problem(nameof(ParameterIsRequired), $"„{caption}\" შევსებული უნდა იყოს");
    }
}
