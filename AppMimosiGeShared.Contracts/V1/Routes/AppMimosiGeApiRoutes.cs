namespace AppMimosiGeShared.Contracts.V1.Routes;

public static class AppMimosiGeApiRoutes
{
    private const string Api = "api";
    private const string Version = "v1";
    public const string ApiBase = Api + "/" + Version;

    public static class StudentContractsRoute
    {
        public const string StudentContractsBase = "/studentcontracts";

        // GET api/v1/studentcontracts/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/studentcontracts/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/studentcontracts/humans?search={text}
        public const string Humans = "/humans";

        // GET api/v1/studentcontracts/{scId:int}
        public const string GetOne = "/{scId:int}";

        // POST api/v1/studentcontracts
        public const string Create = "";

        // PUT api/v1/studentcontracts/{scId:int}
        public const string Update = "/{scId:int}";

        // DELETE api/v1/studentcontracts/{scId:int}
        public const string Delete = "/{scId:int}";
    }
}
