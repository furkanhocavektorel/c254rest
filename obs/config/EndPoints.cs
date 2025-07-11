namespace obs.config
{
    public class EndPoints
    {


        public const string Base = "api/v2";

        // ----  AUTH  ----
        public const string Auth = Base+"/auth";
        public const string Register = "/register";

        // ---- TEACHER ----
        public const string TeacherBase = Base + "/teacher";
        public const string UpdateBrans = "/update-brans/{token}";

        // ---- BRANCH ----
        public const string BranchBase = Base + "/branch";


        // ---- CRUD ----
        public const string Save = "/";
        public const string Update = "/";
        public const string Delete = "/{id}";
        public const string Get = "/";
        public const string GetList = "/list";


    }
}
