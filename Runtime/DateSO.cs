using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DateSO", menuName = "Scriptable Objects/DateSO")]
public class DateSO : ScriptableObject
{
    private enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    [SerializeField] private int year = 2026;
    [SerializeField] private Month month = Month.January;
    [SerializeField] private int day = 1;

    public DateTime ToDateTime()
    {
        return new DateTime(year: year, month: (int)month, day: day);
    }
}