using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraceClassDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string sProdName = "Widget";
            int iUnitQty = 100;
            double dUnitCost = 1.03;

            ConsoleTraceListener trc = new ConsoleTraceListener(true);
            Trace.Listeners.Add(trc);

            Trace.WriteLine("Trace Information-Product Starting ");
            Trace.Indent();

            Trace.WriteLine("The product name is " + sProdName);
            Trace.WriteLine("The product name is" + sProdName, "Field");
            Trace.WriteLineIf(iUnitQty > 50, "This message WILL appear");
            Trace.Assert(dUnitCost > 1, "Message will NOT appear");

            Trace.Unindent();
            Trace.WriteLine("Trace Information-Product Ending");

            Trace.Flush();

            Console.ReadLine();

            /*
             * You can also use the Trace class to produce messages that monitor the execution of an application. 
             * The Trace and Debug classes share most of the same methods to produce output, including the following:
                    WriteLine
                    WriteLineIf
                    Indent
                    Unindent
                    Assert
                    Flush
                You can use the Trace and the Debug classes separately or together in the same application. 
             * In a Debug Solution Configuration project, both Trace and Debug output are active. 
             * The project generates output from both of these classes to all Listener objects. 
             * However, a Release Solution Configuration project only generates output from a Trace class. 
             * The Release Solution Configuration project ignores any Debug class method invocations.
             * 
             * */
        }
    }
}
