using Newtonsoft.Json;

namespace ams.web.Helpers
{
    public static class Helper
    {
        public static class Role
        {
            public const string ADMIN = "admin";
            public const string AGENT = "agent";
            public const string USER = "user";
        }

        public static void SetSession<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T? GetSession<T>(this ISession session, string key)
        {
            var sessions = session.GetString(key);
            return sessions == null ? default(T) : JsonConvert.DeserializeObject<T>(sessions);
        }
    }
}
