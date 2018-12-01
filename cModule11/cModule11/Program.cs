using System.IO;
using System.Dynamic;
using System;

namespace cModule11
{
    class Program : DynamicObject
    {
        private string p_filePath;
        static void Main(string[] args)
        {

        }
        public enum stringSearchEnum
        {
            StartsWith,
            EndsWith,
            Contains
        }

        public Program(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception("File path does not exist.");
            }

            p_filePath = filePath;
        }
    }
}
