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
        
        public static int function_read(int index_path,int index_i,int index_j){
            string line;  
            int[,] metrix  = new int[7,8];
            string path = "";
            if (index_path == 1){
            	path = "facebook.txt";
            }
            else if (index_path == 2){
            	path = "twitter.txt";
            }
            else if (index_path == 3){
            	path = "dropbox.txt";
            }
            
            System.IO.StreamReader file = new System.IO.StreamReader(path);  

            for (int i = 0 ; i < 7 ; ++i ){
                line = file.ReadLine();
                //Console.WriteLine(line);
                string[] words = line.Split(' ');
                for (int j = 0 ;  j < 8 ; ++j){
                    metrix[i,j] = Int32.Parse(words[j]);
                }
            }
            file.Close();  
            return metrix[index_i,index_j];
        }  
    }
}
