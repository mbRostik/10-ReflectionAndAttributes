using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Reflection;

internal class Program
{
    static void Main()
    {
        Type myType = typeof(HarvestingFields);

        while (true)
        {
            string all = Console.ReadLine();
            if (all == "HARVEST")
            {
                break;
            }
            else if (all == "public")
            {
                foreach (FieldInfo field in myType.GetFields( BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {
                    string modificator = "";
                    if (field.IsPublic)
                    {
                        modificator += "public ";
                        Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                    }
                }
            }
            else if (all == "private")
            {
                foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {
                    string modificator = "";
                    if (field.IsPrivate)
                    {
                        modificator += "private ";
                        Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                    }
                }
            }
            else if (all == "protected")
            {
                foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {
                    string modificator = "";
                    if (field.IsFamily)
                    {
                        modificator += "protected ";
                        Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                    }
                }
            }
            else if (all == "all")
            {
                foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                {
                    string modificator = "";

                    if (field.IsPublic)
                        modificator += "public ";
                    else if (field.IsPrivate)
                        modificator += "private ";
                    else if (field.IsAssembly)
                        modificator += "internal ";
                    else if (field.IsFamily)
                        modificator += "protected ";
                    else if (field.IsFamilyAndAssembly)
                        modificator += "private protected ";
                    else if (field.IsFamilyOrAssembly)
                        modificator += "protected internal ";

                    Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                }
            }
            Console.WriteLine();
        }
    }
}
class HarvestingFields
{
    private int testInt;
    public double testDouble;
    protected string testString;
    private long testLong;
    protected double aDouble;
    public string aString;
    private Calendar aCalendar;
    public StringBuilder aBuilder;
    private char testChar;
    public short testShort;
    protected byte testByte;
    public byte aByte;
    protected StringBuilder aBuffer;
    private BigInteger testBigInt;
    protected BigInteger testBigNumber;
    protected float testFloat;
    public float aFloat;
    private Thread aThread;
    public Thread testThread;
    private object aPredicate;
    protected object testPredicate;
    public object anObject;
    private object hiddenObject;
    protected object fatherMotherObject;
    private string anotherString;
    protected string moarString;
    public int anotherIntBitesTheDust;
    private Exception internalException;
    protected Exception inheritableException;
    public Exception justException;
    public Stream aStream;
    protected Stream moarStreamz;
    private Stream secretStream;
}
