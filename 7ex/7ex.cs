using _7ex.Models.Weapons;
using System;

namespace _7ex
{
    internal class Program
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
        static void Main()
        {
            WeaponRepository weapons = new WeaponRepository();

            while (true)
            {
                string all=Console.ReadLine();
                
                if (all == "PrintAll")
                {
                    Console.WriteLine();
                    weapons.PrintAll();
                }
                string temp = "";
                FindWord(ref all, ref temp);
                if (temp == "Add")
                {
                    weapons.AddWeapon(all);
                }
                else if(temp == "AddJew")
                {
                    weapons.AddJew(all);
                }
               else if (temp == "SetRarity")
                {
                    weapons.SetRarity(all);
                }
                else if (temp == "DelJew")
                {
                    weapons.DelJew(all);
                }
                else if (temp == "END")
                {
                    return;
                }
                Console.WriteLine();
            }
        }
    }
}
