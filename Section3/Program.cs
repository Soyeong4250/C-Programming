Days days = Days.Sunday;

if (days == Days.Sunday)
{
    Console.WriteLine("It's Sunday");
}
if (days == Days.Monday)
{
    Console.WriteLine("It's Monday");
}
Console.WriteLine(days);
Console.ReadKey();

enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
};