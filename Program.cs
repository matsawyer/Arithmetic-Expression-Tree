//Matt Sawyer
//11252935
//CptS 322 - Summer 2015
//HW 4 Expression Tree

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArithmeticExpressionTreeHW3CptS322
{
    class Program
    {
        //Main function to start up command menu loop
        static void Main(string[] args)
        {
            ExpTree EXPTree4me = new ExpTree();//initializing tree
            bool done = false;
            string inputexpression = "";
            char[] operands = { '+', '-', '*', '/'};
            string CurrentExpression = "A1+B1+C1"; // default string

            while (done != true) //Loops Command Menu until done is returned as true by quit
            {
                Console.WriteLine("\nMenu (Current Expression='{0}')", CurrentExpression);
                Console.WriteLine(" 1 = Enter new expression");
                Console.WriteLine(" 2 = Set a variable value");
                Console.WriteLine(" 3 = Evaluate tree");
                Console.WriteLine(" 0 = Quit");
                string commandstring = Console.ReadLine();

                if (commandstring == "1")
                {
                    Console.WriteLine("Input new expression: ");
                    inputexpression = Console.ReadLine();
                    CurrentExpression = inputexpression;
                    EXPTree4me.ExpressionString = CurrentExpression;
                }
                else if (commandstring == "2") //Assigns variable name/value into Root node of expression tree
                {
                    Console.WriteLine("Enter variable name: ");
                    string variablename = Console.ReadLine();
                    Console.WriteLine("Enter variable value: ");
                    string variablevaluestring = Console.ReadLine();
                    double inputvariablevalue = Convert.ToDouble(variablevaluestring);
                    EXPTree4me.SetVariable(EXPTree4me.RootTN, variablename, inputvariablevalue);
                }
                else if (commandstring == "3")//writes out expression evaluation to Console
                {
                    Console.WriteLine(EXPTree4me.Evaluation());
                }
                else if (commandstring == "0")//command quit
                {
                    Console.WriteLine("Quitting Application.");
                    done = true;//exits loop
                }
                else//false input check
                {
                    Console.WriteLine("Hey! That wasn't even an option!");
                }
            }
        }
    }
}
