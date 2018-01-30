namespace YiHan.Cms.Web.Navigation
{
    public static class PageNames
    {
        public static class App
        {
            public static class Common
            {
                public const string Administration = "Administration";
                public const string Roles = "Administration.Roles";
                public const string Users = "Administration.Users";
                public const string AuditLogs = "Administration.AuditLogs";
                public const string OrganizationUnits = "Administration.OrganizationUnits";
                public const string Languages = "Administration.Languages";
            }

            public static class Host
            {
                public const string Tenants = "Tenants";
                public const string Editions = "Editions";
                public const string Maintenance = "Administration.Maintenance";
                public const string Settings = "Administration.Settings.Host";
            }

            public static class Tenant
            {
                public const string Dashboard = "Dashboard.Tenant";
                public const string Settings = "Administration.Settings.Tenant";
            }
            public static class Artice
            {
                public const string ArticeList = "Artice";

            }
            public static class Temp
            {
                public const string TempSystem = "TempSystem";
                public const string IndexTemp = "IndexTemp";
                public const string LyoutTemp = "LyoutTemp";
                public const string ContentTemp = "ContentTemp";
                public const string ChannelTemp = "ChannelTemp";
                public const string OnlyTemp = "OnlyTemp";
            }
            public static class Category
            {
                public const string CategoryList = "Category";

            }
        }

        public static class Frontend
        {
            public const string Home = "Frontend.Home";
            public const string About = "Frontend.About";
        }
    }
}