using S2Lab5;

int x;
StudentBudget TheBest = new StudentBudget("IK-33", "artem", "valko", 18, 0);
TheBest.Write();

Console.WriteLine("чи отримує студент степендію? 1=yes 0=no");
x = int.Parse(Console.ReadLine());
if (x == 0)
{
    TheBest.setScholarship(0);
}
else
{
    TheBest.setScholarship(2000);
}
TheBest.Write();



