namespace ProjectBaseIdentity.Helpers;

public static class DateTimeHelper
{
    public static long DateTimeToUnixTimestamp(DateTime dateTime)
    {
        return (long)(dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
    }
}
