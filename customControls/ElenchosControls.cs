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
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Elenchos
{
    //------------------------------------------------------------------------------------
    //--------------------------------CUSTOM CONTROLS-------------------------------------
    //------------------------------------------------------------------------------------
    //custom prompt box
    public static class Prompt
    {
        public static int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 100;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
            System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return (int)inputBox.Value;
        }
    }

    [Designer(typeof(ParentControlDesigner))]
    public partial class CustomPanel : UserControl
    {
        Color _borderColor = Color.Blue;
        int _borderWidth = 5;

        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                Invalidate();
                PerformLayout();
            }
        }

        public CustomPanel() {  }

        public override Rectangle DisplayRectangle
        {
            get
            {
                return new Rectangle(_borderWidth, _borderWidth, Bounds.Width - _borderWidth * 2, Bounds.Height - _borderWidth * 2);
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        new public BorderStyle BorderStyle
        {
            get { return _borderWidth == 0 ? BorderStyle.None : BorderStyle.FixedSingle; }
            set { }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (this.BorderStyle == BorderStyle.FixedSingle)
            {
                using (Pen p = new Pen(_borderColor, _borderWidth))
                {
                    Rectangle r = ClientRectangle;
                    // now for the funky stuff...
                    // to get the rectangle drawn correctly, we actually need to 
                    // adjust the rectangle as .net centers the line, based on width, 
                    // on the provided rectangle.
                    r.Inflate(-Convert.ToInt32(_borderWidth / 2.0 + .5), -Convert.ToInt32(_borderWidth / 2.0 + .5));
                    e.Graphics.DrawRectangle(p, r);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetDisplayRectLocation(_borderWidth, _borderWidth);
        }
    }

    public class SmallTextbox : SmallTextBox
    {
        public SmallTextbox() { }
        private string placeholderText = string.Empty;

        [Localizable(true)]
        [DefaultValue("")]
        //[SRDescription(nameof(SR.TextBoxPlaceholderTextDescr))]
        public virtual string PlaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                if (value is null)
                {
                    value = string.Empty;
                }

                if (placeholderText != value)
                {
                    placeholderText = value;
                    if (IsHandleCreated)
                    {
                        Invalidate();
                    }
                }
            }
        }
    }

    //custom control box
    public class ControlBoxNoMin : ControlBox
    {
        
    }


    //Disables the capslock tooltip
    public class PasswordTextBox : System.Windows.Forms.TextBox
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

    public class ColorTextbox : System.Windows.Forms.TextBox
    {
        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        Color borderColor = Color.Blue;
    }
}
