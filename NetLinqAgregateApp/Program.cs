using ExampleClassLibrary;

var users = new List<User>()
{
    new("Sam", 35),
    new("Bob", 31),
    new("Tim", 29),
    new("Joe", 42),
    new("Leo", 35),
    new("Tom", 41),
    new("Bill", 19),
    new("Ann", 35),
    new("Poul", 24),
    new("Leo", 30),
};

// Count
int users30Count = users.Count(u => u.Age >= 35);
// int users30Count = users.Where(u => u.Age >= 35).Count();

Console.WriteLine($"Users age >= 35 = {users30Count}");

int ageMin = users.Min(u => u.Age);
int ageMax = users.Max(u => u.Age);
double ageAvg = users.Average(u => u.Age);
double ageSum = users.Sum(u => u.Age);

Console.WriteLine($"Age: min = {ageMin}, nax = {ageMax}, avg = {ageAvg}, sum = {ageSum}");

double proc = users.Aggregate(0, (double acc, User u) => {
    acc = acc + u.Age * 0.15;
    //
    return acc;
    }
);
Console.WriteLine(proc);