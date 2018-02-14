using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArBitor
{
    public class SystemDump
    {
        private static SystemDump instance;
        private static readonly object obj = new object();

        private SystemDump()
        {
            
        }

        public static SystemDump getInstance
        {
            get
            {
                if (instance == null)
                    lock(obj)
                    {
                        if (instance == null)
                            instance = new SystemDump();
                    }
                return instance;
            }
        }
    }
}
