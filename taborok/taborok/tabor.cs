using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace taborok
{
    public record Tabor(int StartingMonth, int StartingDay, int EndingMonth, int EndingDay, string StudentsABC, string CampType)
    {
        
    }
}