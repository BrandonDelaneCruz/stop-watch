using System.Globalization;

bool keepLooping = true;

while (keepLooping)
{
    Console.WriteLine("Press to start.");

    var userSaidStart = Console.ReadLine();

    var startTime = DateTime.Now;

    Console.Clear();

    Console.WriteLine("Press to end.");

    var userSaidStop = Console.ReadLine();

    var endTime = DateTime.Now;

    var howLongDidHeWaitToPressTheButton = endTime - startTime;

    #region Print values and confirm user wants to continue
    Console.Clear();

    Console.WriteLine($"Time Elapsed {howLongDidHeWaitToPressTheButton}. Press return to begin again.");

    Console.WriteLine("If yes enter (y) if no enter (n).");
    #endregion

    string userResponse = "";

    bool isResponseValid = false;
    while (!isResponseValid)
    {
        userResponse = Console.ReadLine();

        if (userResponse == "y" || userResponse == "n")
        {
            isResponseValid = true;
        }
        else
        {
            Console.WriteLine("Invalid response.Please enter a valid repsonse.");
        }
    }

    // loop that keeps going until userResponse is valid

    if (userResponse == "n")
    {
        keepLooping = false;
    }

    Console.Clear();
}
