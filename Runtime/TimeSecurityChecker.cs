using System;

public class TimeSecurityChecker
{
    public static bool IsOutOfTime(DateSO source)
    {
        return DateTime.Now > source.ToDateTime();
    }
}