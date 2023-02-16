
Console.WriteLine("=====================================");
Console.WriteLine("       Compute Average Grade");
Console.WriteLine("=====================================");

Console.WriteLine("PLEASE ENGLISH GRADE:");
double score_english = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("PLEASE  MATH GRADE:");
double score_math = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("PLEASE FILPINO GRADE:");
double score_filipino = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("PLEASE PHYSICS GRADE:");
double score_physics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("PLEASE COMPROGRAMMING GRADE:");
double score_comprogramming = Convert.ToInt32(Console.ReadLine());

var average_score = (score_english + score_math + score_filipino + score_physics + score_comprogramming) / 5;

if (average_score >= 75)
{
    Console.WriteLine("PASSED");
}
else
{
    Console.WriteLine("FAILED");
}