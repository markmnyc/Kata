using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {
        public int AddNumb(int numb1, int numb2)
        {
            return numb1 + numb2;
        }
         
        public int MinusNumb(int numb1, int numb2)
        {
            return numb1 - numb2;
        }

        public string doOperation(string operationName, int numb1, int numb2)
        {
            object[] mParam = new object[] { numb1, numb2 };
            MyClass myClassObj = new MyClass();
            Type myClassType = myClassObj.GetType();
            MethodInfo myMethodInfo = myClassType.GetMethod(operationName);
            return myMethodInfo.Invoke(myClassObj, mParam).ToString();
            
        }
    }
}
