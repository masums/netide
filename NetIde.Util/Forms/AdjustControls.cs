/*
 * Copyright � 2007 Jos� Gallardo Salazar
 * 
 * Design Notes:-
 * --------------
 * References:
 * - http://www.mobilepractices.com/2007/12/adaptative-ui-sample-using-our.html
 * 
 * Revision Control:-
 * ------------------
 * Created On: 2007 December 11
 * 
 * $Revision:$
 * $LastChangedDate:$
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetIde.Util.Win32;

namespace NetIde.Util.Forms
{
    internal class AdjustControls
    {
        /// <summary>
        /// Measure a multiline string
        /// </summary>
        /// <param name="gr">Graphics</param>
        /// <param name="text">string to measure</param>
        /// <param name="rect">Original rect. The width will be taken as fixed.</param>
        /// <param name="textboxControl">True if you want to measure the string for a textbox control</param>
        /// <returns>A Size object with the measure of the string according with the params</returns>
        static public Size GetBestSize(Graphics gr, string text, Rectangle rect, bool textboxControl)
        {
            NativeMethods.RECT bounds = new NativeMethods.RECT(rect);
            IntPtr hdc = gr.GetHdc();
            int flags = NativeMethods.DT_CALCRECT | NativeMethods.DT_WORDBREAK;
            if (textboxControl) flags |= NativeMethods.DT_EDITCONTROL;
            NativeMethods.DrawText(hdc, text, text.Length, ref bounds, flags);
            gr.ReleaseHdc(hdc);

            return new Size(bounds.right - bounds.left, bounds.bottom - bounds.top + (textboxControl ? 6 : 0));
        }

        /// <summary>
        /// Measure a multiline string for a Control
        /// 
        /// http://www.mobilepractices.com/2008/01/making-multiline-measurestring-work.html
        /// </summary>
        /// <param name="control">control</param>
        /// <param name="text">string to measure</param>
        /// <param name="rect">Original rect. The width will be taken as fixed.</param>
        /// <returns>A Size object with the measure of the string according with the params</returns>
        static public Size GetBestSize(Control control, string text, Rectangle rect)
        {
            Size result = Size.Empty;
            IntPtr controlFont = control.Font.ToHfont();
            IntPtr hDC = NativeMethods.GetDC(control.Handle);
            using (Graphics gr = Graphics.FromHdc(hDC))
            {
                IntPtr originalObject = NativeMethods.SelectObject(hDC, controlFont);
                result = GetBestSize(gr, text, rect, control is System.Windows.Forms.TextBox);
                NativeMethods.SelectObject(hDC, originalObject); //Release resources  
            }
            return result;
        }
    }
}
