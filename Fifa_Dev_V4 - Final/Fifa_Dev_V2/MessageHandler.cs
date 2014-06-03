using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifa_Dev_V2
{
    class MessageHandler
    {
        public static void ShowMessage(string msgText)
        {
            MessageBox.Show(msgText);
        }

        public static void ShowMessage(string msgText, string caption, MessageBoxButtons msgbtn, MessageBoxIcon msgIcon)
        {
            MessageBox.Show(msgText, caption, msgbtn, msgIcon);
        }
    }
}
