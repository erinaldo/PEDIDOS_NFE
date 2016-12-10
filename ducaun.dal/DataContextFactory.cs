using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducaun.dal
{
    public class DataContextFactory

    {
        private static fodeuDataContext dataContext;
        public static fodeuDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new fodeuDataContext();

                return dataContext;
            }
        }
    }
}
