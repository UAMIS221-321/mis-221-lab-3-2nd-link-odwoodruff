//Main



string enjoymentLevel = GetEnjoymentLevel();

string stadium = GetStadiumRecommendation(enjoymentLevel);

string game = GetGameRecommendation(stadium);

DisplayStadiumDetails(stadium, game);




//End main

static string GetEnjoymentLevel()
{
    System.Console.WriteLine("What is your preferrered level of enjoyment(Boring, Average, Fun, Epic)?");

    string enjoymentLevel = Console.ReadLine();
    Console.WriteLine("You chose: " + enjoymentLevel);

    return enjoymentLevel;
}








static string GetStadiumRecommendation(string enjoymentLevel)
{
    if (enjoymentLevel == "Boring")
    {
        return "Neyland Stadium";
    }
    else if (enjoymentLevel == "Average")
    {
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "Fun")
    {
        return "Tiger Stadium";
    }
    else if (enjoymentLevel == "Epic")
    {
        return "Saban Field at Bryant-Denny Stadium";
    }
    else
    {
        return "Invalid enjoyment level";
    }
}




static string GetGameRecommendation(string stadium)
{
    if (stadium == "Neyland Stadium")
    {
        return "vs Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium")
    {
        return "vs Kentucky";
    }
    else if (stadium == "Tiger Stadium")
    {
        return "vs Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium")
    {
        return "vs Auburn";
    }
    else
    {
        return "Invalid Stadium ";
    }

}




static void DisplayStadiumDetails(string stadium, string game)
{
    System.Console.WriteLine($"Based on your interests the best stadium for you is at {stadium} playing {game}. ");
}