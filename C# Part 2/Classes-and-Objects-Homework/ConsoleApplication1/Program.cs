using System;
using System.Collections.Generic;
using System.Text;

namespace sdasdasd
{
    /*
      (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)	                  ~10.6
          pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)	~21.22
   
     */
    class TriangleSurface
    {
        
           public static List<char> operators = new List<char>() { '+', '-', '*', '/' };
           public static List<char> brackets = new List<char>() { '(', ')' };
           public static List<string> functions = new List<string>() { "pow", "sqrt", "ln" };

           // METHODS:

           public static List<string> SeparatedTokens(string input)
        {
            var result = new List<string>();

            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                // Check for minus:
                if (input[i] == '-' && (i == 0 || input[i-1] == ',' || input[i - 1] == '(') ) 
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }

                // Check for brackets:
                if ( brackets.Contains(input[i]) )
                {
                    result.Add(input[i].ToString());
                }
                // Check for operators:
                else if ( operators.Contains(input[i]) )
                {
                    result.Add(input[i].ToString());
                }
                // Check for ln:
                else if ( i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                // Check for pow:
                else if ( i + 2 < input.Length && input.Substring(i, 3).ToLower() == "ln")
                {
                    result.Add("pow");
                    i += 2;
                }
                // Check for sqrt:
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }

            }
            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }

            return result;
        }

        public static int Precedence(string aritmOperator)
           {
               if (aritmOperator == "+" || aritmOperator == "-")
               {
                   return 1;
               }
               else
               {
                   return 2;
               }
           }

        public static Queue<string> ConvertToRPN(List<string> tokens)
           {
               Stack<string> stack = new Stack<string>();
               Queue<string> queue = new Queue<string>();

              

               for (int i = 0; i < tokens.Count; i++)
               {
                   var currentToken = tokens[i];
                   double number;

               if (double.TryParse(currentToken, out number))
               {
                   queue.Enqueue(currentToken);
               }
               else if ( functions.Contains(currentToken) )
               {
                   stack.Push(currentToken);
               }
           
               else if (currentToken == ",")
               {
                   if (!stack.Contains("(") || stack.Count == 0)
                   {
                       throw new ArgumentException("Invalid brackets or function separator.");
                   }

                   while ( stack.Peek() != "(")
                   {
                       queue.Enqueue(stack.Pop());
                       // If not working => you may need to pop the "("
                   }
               }     
                  
                       else if (operators.Contains(currentToken[0]))
               {
                   // if not working  = refactro lofic curre
                while (stack.Count != 0 && operators.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
                stack.Push(currentToken);
        //
               }

               else if (currentToken == "(")
               {
                   stack.Push("(");
               }
               else if(currentToken == ")")
               {
                   if (!stack.Contains("(") || stack.Count == 0)
                   {
                       throw new ArgumentException("Invalid brackets.");
                   }
                   while (stack.Peek() != "(")
                   {
                       queue.Enqueue(stack.Pop());
                   }
                   stack.Pop();

                   if (stack.Count != 0 &&functions.Contains(stack.Peek()))
                   {
                       queue.Enqueue(stack.Pop());
                   }
               }

               }

               while (stack.Count != 0)
               {
                   if (brackets.Contains(stack.Pop()[0]))
                   {
                       throw new ArgumentException("Invalid brackets.");
                   }

                   queue.Enqueue(stack.Pop());
               }

               return queue;
           }

           static void Main(string[] args)
           {
        
            // Input and Trim input:
            string input = Console.ReadLine().Trim();
            string trimmedInput = input.Replace(" ", string.Empty);

      //   Console.WriteLine(trimmedInput);
            var separatedTokens = SeparatedTokens(trimmedInput);
            var rpn = ConvertToRPN(separatedTokens);
                     
            
        }
    

    }
}