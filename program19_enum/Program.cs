DayOfWeek dayOfWeek = DayOfWeek.Lunes;

System.Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

System.Console.WriteLine(dayOfWeek);

System.Console.WriteLine((int)dayOfWeek);

System.Console.WriteLine((DayOfWeek)3);

DayOfWeek nextDay = GetNextDay(dayOfWeek);

System.Console.WriteLine(nextDay);

static DayOfWeek GetNextDay(DayOfWeek day)
{
    if (day < DayOfWeek.Domingo) return day + 1;
    return DayOfWeek.Lunes;
}