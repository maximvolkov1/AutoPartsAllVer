using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsApp.AppDate
{
    internal class Connect
    {
        public static DBAutoPartsEntities4 context;
        public static DBAutoPartsEntities4 GetCont()
        {
            if (context == null) context = new DBAutoPartsEntities4();
            return context;
        }
    }
}
