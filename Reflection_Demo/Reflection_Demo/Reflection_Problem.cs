using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    //Reflection allows to inspect for information of classs,method,Constctor field at run time.
    //It is a pross of descriving the meta data of a method,constructor fiels etc in a code.
    //Meta data refers ta a binary information saved in a memory.
    public class Reflection_Problem
    {
        public static void DataInfo()
        {
            Type type = Type.GetType("Reflection_Demo.CustomerClass");
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine("****************************************");
            PropertyInfo[] property = type.GetProperties();
            foreach (PropertyInfo info in property)
            {
                Console.WriteLine(info.PropertyType.Name+":"+info.Name);
            }
            Console.WriteLine("******************************************");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine("*******************************************");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo info in methods)
            {
                Console.WriteLine(info.ReturnType.Name+":"+info.Name);
            }
        }
    }
}
