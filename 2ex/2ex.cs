using System;
using System.Reflection;


public class BlackBoxInteger
{
    private static int DefaultValue = 0;

    private int innerValue;

    public BlackBoxInteger(int innerValue)
    {
        this.innerValue = innerValue;
    }

    public BlackBoxInteger()
    {
        this.innerValue = DefaultValue;
    }

    private void Add(int addend)
    {
        this.innerValue += addend;
    }

    private void Subtract(int subtrahend)
    {
        this.innerValue -= subtrahend;
    }

    private void Multiply(int multiplier)
    {
        this.innerValue *= multiplier;
    }

    private void Divide(int divider)
    {
        this.innerValue /= divider;
    }

    private void LeftShift(int shifter)
    {
        this.innerValue <<= shifter;
    }

    private void RightShift(int shifter)
    {
        this.innerValue >>= shifter;
    }

}


public class Program
{
    static void FindWord(ref string v, ref string temp)
    {
        string b = "";
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == ' ')
            {
                v = v.Remove(i, 1);
                break;
            }
            else
            {
                b += v[i];
                v = v.Remove(i, 1);
                i--;
            }
        }
        temp = b;
    }
    public static void Main()
    {
        Type myType = typeof(BlackBoxInteger);
        BlackBoxInteger all = new BlackBoxInteger();
        while (true)
        {
            string a = Console.ReadLine();
            if (a == "END")
            {
                break;
            }

            string temp = "";
            FindWord(ref a, ref temp);


            foreach (MethodInfo method in myType.GetMethods(BindingFlags.DeclaredOnly
                        | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (method.Name == temp)
                {
                    var numb = typeof(BlackBoxInteger).GetMethod(temp,
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic);

                    numb?.Invoke(all, parameters: new object[] { int.Parse(a) });
                    var name = myType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);

                    var value = name?.GetValue(all);
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine();
        }
    }
}
