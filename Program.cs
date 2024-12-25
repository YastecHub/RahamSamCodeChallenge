// See https://aka.ms/new-console-template for more information
using RahamSamCodeChallenge;

BaseBallGame game = new BaseBallGame();

string[] ops1 = ["5", "-2", "4", "C", "D", "9", "+", "+"];
string[] ops2 = ["5"];

Console.WriteLine($"Your Total BaseBall Point is: {game.GamePoints(ops2)}");