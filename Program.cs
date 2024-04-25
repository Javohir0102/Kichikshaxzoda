using LittlePrince.Kichikshaxzoda;

var testCase = int.Parse(Console.ReadLine()?? "0");

while(testCase-- > 0)
{
    var crossingCount = 0;

    var dots = Console.ReadLine()?
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    var prince = new Coordinate(dots![0], dots![1]);
    var princess = new Coordinate(dots![2], dots![3]);

    var numberOfPlanetes = int.Parse(Console.ReadLine()?? "0");
    while(numberOfPlanetes-- > 0)
    {
        var planeteDate = Console.ReadLine()?
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        var center  = new Coordinate(planeteDate![0], planeteDate![1]);
        var planete = new Circle(center, planeteDate[2]);

        var princeIn   = planete.IsIn(prince);
        var princessIn = planete.IsIn(princess);
        var crossOut   = princeIn ^ princessIn;
        if (crossOut)
            crossingCount++;
    }
    Console.WriteLine(crossingCount);
}

