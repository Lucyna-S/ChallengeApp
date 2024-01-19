int[] grades = new int[365];
List<string> daysOfWeek = new List<string>();
daysOfWeek.Add("poniedziałek");
daysOfWeek.Add("wtorek");
daysOfWeek.Add("środa");
daysOfWeek.Add("czwartek");
daysOfWeek.Add("piątek");
daysOfWeek.Add("sobota");
daysOfWeek.Add("niedziela");


for (var i=0; i<daysOfWeek.Count; i++)
{
    Console.WriteLine(daysOfWeek[i]);
}

foreach( var day in daysOfWeek)
{
    Console.WriteLine(day);
}


