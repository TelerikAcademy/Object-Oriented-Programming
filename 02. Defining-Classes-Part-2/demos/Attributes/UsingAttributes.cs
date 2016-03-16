using System;
using System.Runtime.InteropServices;

class UsingAttributes
{
	[DllImport("user32.dll", EntryPoint = "MessageBox")]
	public static extern int ShowMessageBox(int hWnd,
		string text, string caption, int type);

	static void Main()
	{
		ShowMessageBox(0, "Some text", "Some caption", 0);
	}
}
