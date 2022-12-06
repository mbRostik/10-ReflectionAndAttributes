namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using _03BarracksFactory.Models.Units;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {

            Type[] typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "_03BarracksFactory.Models.Units").ToArray();
            foreach (Type type in typelist)
            {
                object targetObject = Activator.CreateInstance(Type.GetType(type.FullName));

                string temp = targetObject.GetType().ToString();

                Type myType = Type.GetType(temp);
                object obj = Activator.CreateInstance(myType);

                string temp2 = "";

                for(int i = temp.Length - 1; true; i--)
                {
                    if (temp[i] == '.')
                    {
                        break;
                    }
                    temp2 += temp[i];
                }
                temp = new string(temp2.ToCharArray().Reverse().ToArray());

                if (unitType == temp)
                {
                    return (Unit)obj;
                }
            }
            return null;
        }

        
    }
}
