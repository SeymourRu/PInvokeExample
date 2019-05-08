using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ExampleApplication
{
    public class DLLApi
    {
        private static List<int> IntValues = new List<int>();
        private static List<float> FloatValues = new List<float>();
        private static List<double> DoubleValues = new List<double>();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void IntCallback(int result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void FloatCallback(float result);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void DoubleCallback(double result);

        [DllImport("API.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void GetInt64Values(IntCallback cb);

        [DllImport("API.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void GetFloatValues(FloatCallback cb);

        [DllImport("API.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void GetDoubleValues(DoubleCallback cb);

        private static void OnIntCallback(int result)
        {
            Console.WriteLine("OnInt64Callback Answer - {0}", result);
            IntValues.Add(result);
        }

        private static void OnFloatCallback(float result)
        {
            Console.WriteLine("OnFloatCallback Answer - {0}", result);
            FloatValues.Add(result);
        }

        private static void OnDoubleCallback(double result)
        {
            Console.WriteLine("OnDoubleCallback Answer - {0}", result);
            DoubleValues.Add(result);
        }

        public static List<int> ReadIntValuesFromDll()
        {
            IntValues.Clear();
            GetInt64Values(OnIntCallback);
            return IntValues;
        }

        public static List<float> ReadFloatValuesFromDll()
        {
            FloatValues.Clear();
            GetFloatValues(OnFloatCallback);
            return FloatValues;
        }

        public static List<double> ReadDoubleValuesFromDll()
        {
            DoubleValues.Clear();
            GetDoubleValues(OnDoubleCallback);
            return DoubleValues;
        }
    }
}