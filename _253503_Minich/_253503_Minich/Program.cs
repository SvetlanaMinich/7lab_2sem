using _253503_Minich;

public class Program
{
    public static void Main(string[] args)
    {
        CharacterSet set1 = new CharacterSet("abc");
        Console.WriteLine("Characters: " + string.Join("", set1.Characters));
        bool isValid = set1.IsValidSet();
        Console.WriteLine("Is valid set? " + isValid);
        CharacterSet set2 = new CharacterSet("bcd");
        CharacterSet union = set1 + set2;
        CharacterSet intersection = set1 * set2;
        CharacterSet difference = set1 - set2;
        Console.WriteLine("Union: " + string.Join("", union.Characters));
        Console.WriteLine("Intersection: " + string.Join("", intersection.Characters));
        Console.WriteLine("Difference: " + string.Join("", difference.Characters));
        bool areEqual = set1.Equals(set2);
        Console.WriteLine("Are equal? " + areEqual);
        string setString = set1.ToString();
        Console.WriteLine("Set string: " + setString);
        CharacterSet newSet = (CharacterSet)"xyz";
        Console.WriteLine("New set characters: " + string.Join("", newSet.Characters));
        set1++;
        set2--;
        Console.WriteLine("Set1 after increment: " + string.Join("", set1.Characters));
        Console.WriteLine("Set2 after decrement: " + string.Join("", set2.Characters));
    }
}
