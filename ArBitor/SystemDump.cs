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
        public DateTime a = new DateTime();
        

        public SystemDump()
        {
            a = DateTime.Now;
        }

        public static SystemDump getInstance()
        {
            //if (instance == null)
            // На всякий случай, ещё раз проверим не был
            // ли объект создан другим потоком, пока
            // текущий ждал освобождения блокировки.
            if (instance == null)
                instance = new SystemDump();

            return instance;
        }
    }
}
