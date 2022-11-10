using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser_mini_project
{
    public class Parsar 
    {

        // constructor
        public Parsar()
        {

        }

        public static bool IsBalanced(string wooah)
        {
            Stack<int> freeInts = new Stack<int>();

            for (int i = 0; i < wooah.Length; i++)
            {
                if (wooah[i] == '(' )
                {
                    freeInts.Push(i);
                }
                if (wooah[i] == ')')
                {
                    try
                    {
                        freeInts.Pop();
                    }
                    catch (InvalidOperationException e)
                    {
                        return false;
                    }
                }
            }
            
            if(freeInts.Count == 0)
            {
                return true;
            }
            
            return false;

            
        }
        
        // method takes string, returns the posistion of the last char that (
        public static int FindImbalance(string testy)
        {
            Stack<int> floatyBoaty = new Stack<int>();

            for (int i = 0; i < testy.Length; i++)
            {
                if (testy[i] == '(')
                {
                    floatyBoaty.Push(i);
                }
                if (testy[i] == ')')
                {
                    try
                    {
                        floatyBoaty.Pop();
                    }
                    catch
                    {
                        return -1;
                    }
                }
            }

            try
            {
                return floatyBoaty.Peek();
            }
            catch
            {
                return -1;
            }

            
        }
        
    }
}
