using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace TooManyProcs
{
   public class CTooManyProcs
   {
      public static bool TooMany(string strProcName, int intHowManyOk)
      {
         return Process.GetProcesses().Where(proc => proc.ProcessName.Equals(strProcName, StringComparison.CurrentCultureIgnoreCase)).Count() >= intHowManyOk;
      }

      public static bool TooMany(Regex rxProcName, int intHowManyOk)
      {
         return Process.GetProcesses().Where(proc => rxProcName.IsMatch(proc.ProcessName)).Count() >= intHowManyOk;
      }

      public static string GetMyProcName()
      {
         return Process.GetCurrentProcess().ProcessName;
      }
   }
}
