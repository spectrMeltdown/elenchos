using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Elenchos
{
    //------------------------------------------------------------------------------------
    //--------------------------------CUSTOM CONTROLS-------------------------------------
    //------------------------------------------------------------------------------------

    //Disables the capslock tooltip
    public class PasswordTextBox : TextBox
    {
        
        public PasswordTextBox()
        {

        }

        private const int EM_SHOWBALLOONTIP = 0x1503;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == EM_SHOWBALLOONTIP)
            {
                m.Result = (IntPtr)0;
                return;
            }
            base.WndProc(ref m);
        }
    }
}
