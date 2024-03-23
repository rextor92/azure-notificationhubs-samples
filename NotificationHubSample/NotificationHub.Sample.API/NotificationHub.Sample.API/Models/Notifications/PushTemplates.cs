namespace NotificationHub.Sample.API.Models
{
    public static class PushTemplates
    {
        public static class Generic
        {
            public const string Android = "{ \"message\" : { \"notification\": { \"title\" : \"$(title)\", \"body\" : \"$(alertMessage)\"} } }";
            public const string iOS = "{ \"aps\" : {\"alert\" : \"$(alertMessage)\"} }";
        }

        public static class Silent
        {
            public const string Android = "{ \"message\" : { \"data\" : {\"message\" : \"$(alertMessage)\"} } }";
            public const string iOS = "{ \"aps\" : {\"content-available\" : 1, \"apns-priority\": 5, \"sound\" : \"\", \"badge\" : 0}, \"message\" : \"$(alertMessage)\" }";
        }
    }
}
