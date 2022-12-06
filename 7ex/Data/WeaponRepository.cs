using _7ex.Models.Jewels;
using _7ex.Models.Quality;
using _7ex.Models.RarityW;
using _7ex.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _7ex
{

    internal class WeaponRepository
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
        List<Weapon> all = new List<Weapon>();

        public void PrintAll()
        {
            foreach (Weapon weapon in all)
            {
                Console.WriteLine(weapon.ToString());
            }
        }
        
        public void AddWeapon(string st)
        {
            string weaponType = "";
            FindWord(ref st, ref weaponType);
            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_7ex.Models.Weapons").ToArray();
            foreach (Type type in typelist)
            {
                object targetObject = Activator.CreateInstance(Type.GetType(type.FullName));

                string temp = targetObject.GetType().ToString();

                Type myType = Type.GetType(temp);
                object obj = Activator.CreateInstance(myType);

                string temp2 = "";

                for (int i = temp.Length - 1; true; i--)
                {
                    if (temp[i] == '.')
                    {
                        break;
                    }
                    temp2 += temp[i];
                }
                temp = new string(temp2.ToCharArray().Reverse().ToArray());
                if (weaponType == temp)
                {

                    all.Add((Weapon)obj);

                    all[all.Count - 1].Name = st;
                    return;
                }
            }
            Console.WriteLine("We can't find this type of weapon");
        }

        public void AddJew(string st)
        {
            string nsword = "";
            FindWord(ref st, ref nsword);
            string namejew = "";
            FindWord(ref st, ref namejew);

            Jewel jwl = new Jewel();

            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_7ex.Models.Jewels").ToArray();
            foreach (Type type in typelist)
            {
                object targetObject = Activator.CreateInstance(Type.GetType(type.FullName));

                string temp = targetObject.GetType().ToString();

                Type myType = Type.GetType(temp);
                object obj = Activator.CreateInstance(myType);

                string temp2 = "";

                for (int i = temp.Length - 1; true; i--)
                {
                    if (temp[i] == '.')
                    {
                        break;
                    }
                    temp2 += temp[i];
                }
                temp = new string(temp2.ToCharArray().Reverse().ToArray());
                if (namejew == temp)
                {
                    
                    jwl = (Jewel)obj;

                    Type[] typelistj = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_7ex.Models.Quality").ToArray();
                    foreach (Type typej in typelistj)
                    {

                        object targetObjectj = Activator.CreateInstance(Type.GetType(typej.FullName));

                        string tempj = targetObjectj.GetType().ToString();

                        Type myTypej = Type.GetType(tempj);
                        object objj = Activator.CreateInstance(myTypej);

                        string temp2j = "";

                        for (int i = tempj.Length - 1; true; i--)
                        {
                            if (tempj[i] == '.')
                            {
                                break;
                            }
                            temp2j += tempj[i];
                        }
                        tempj = new string(temp2j.ToCharArray().Reverse().ToArray());
                        if (st == tempj)
                        {
                            jwl.JewelQual((QualityJew)objj);

                            for (int it = 0; it != all.Count; it++)
                            {
                                if (all[it].Name == nsword)
                                {
                                    all[it].Jewels(jwl);
                                    return;
                                }
                            }
                            Console.WriteLine("We can not find this kind of Weapon!");
                        }
                    }
                }

                
            }
        }

        public void SetRarity(string st)
        {
            string NameSword = "";
            FindWord(ref st, ref NameSword);
            st += "W";
            RarityWeapon r;
            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_7ex.Models.RarityW").ToArray();
            foreach (Type type in typelist)
            {
                object targetObject = Activator.CreateInstance(Type.GetType(type.FullName));

                string temp = targetObject.GetType().ToString();

                Type myType = Type.GetType(temp);
                object obj = Activator.CreateInstance(myType);

                string temp2 = "";

                for (int i = temp.Length - 1; true; i--)
                {
                    if (temp[i] == '.')
                    {
                        break;
                    }
                    temp2 += temp[i];
                }
                temp = new string(temp2.ToCharArray().Reverse().ToArray());
                if (st == temp)
                {
                    r = (RarityWeapon)obj;
                    for (int i = 0; i != all.Count; i++)
                    {
                        if (all[i].Name == NameSword)
                        {
                            all[i].WeaponSetRarity(r);
                            return;
                        }
                    }
                    Console.WriteLine("We can't find this type of weapon");
                    return;
                }

            }
            Console.WriteLine("We can't find this type of rarity");

        }

        public void DelJew(string st)
        {
            string sname = "";
            FindWord(ref st, ref sname);
            for(int i = 0; i != all.Count; i++)
            {
                if (all[i].Name == sname)
                {
                    all[i].DelJewels(int.Parse(st));
                    return;
                }
            }
            Console.WriteLine("Can not find this sword");
        }
    }
}