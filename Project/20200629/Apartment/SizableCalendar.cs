using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Apartment
{
    public class SizableCalendar : MonthCalendar
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        protected override void OnHandleCreated(EventArgs e)
        {
            SetWindowTheme(Handle, string.Empty, string.Empty);
            base.OnHandleCreated(e);
        }
    }
}
