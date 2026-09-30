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

    public static class TeacherContractsRoute
    {
        public const string TeacherContractsBase = "/teachercontracts";

        // GET api/v1/teachercontracts/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/teachercontracts/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/teachercontracts/humans?search={text}
        public const string Humans = "/humans";

        // GET api/v1/teachercontracts/{id:int}
        public const string GetOne = "/{id:int}";

        // POST api/v1/teachercontracts
        public const string Create = "";

        // PUT api/v1/teachercontracts/{id:int}
        public const string Update = "/{id:int}";

        // DELETE api/v1/teachercontracts/{id:int}
        public const string Delete = "/{id:int}";
    }

    public static class GroupsRoute
    {
        public const string GroupsBase = "/groups";

        // GET api/v1/groups/rowsdata?filterSortRequest={base64}
        public const string RowsData = "/rowsdata";

        // GET api/v1/groups/formlookups
        public const string FormLookups = "/formlookups";

        // GET api/v1/groups/studentcontracts?academicYearId={id}
        public const string StudentContracts = "/studentcontracts";

        // GET api/v1/groups/{grpId:int}
        public const string GetOne = "/{grpId:int}";

        // POST api/v1/groups
        public const string Create = "";

        // PUT api/v1/groups/{grpId:int}
        public const string Update = "/{grpId:int}";

        // DELETE api/v1/groups/{grpId:int}
        public const string Delete = "/{grpId:int}";
    }
}
