using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// The math library that can be used in your model.
    /// all methods should be declared as public static.
    /// 
    /// The parameters must be of type "int", or "int array"
    /// The number of parameters can be 0 or many
    /// 
    /// The return type can be bool, int or int[] only.
    /// 
    /// The method name will be used directly in your model.
    /// e.g. call(max, 10, 2), call(dominate, 3, 2), call(amax, [1,3,5]),
    /// 
    /// Note: method names are case sensetive
    /// </summary>
    public class NewLib
    {
	    public static bool dummy(int[] values)
        {
		        return true;
        }
        
        public static bool Read(double[] matrix)
        {
            try
            {
                StreamReader sr = new StreamReader("facebook.txt",Encoding.Default);
            	String line;
            	while ((line = sr.ReadLine()) != null) 
            	{
                	Console.WriteLine(line.ToString());
            	}
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            return true;
        }
        
        
        
    }
}
