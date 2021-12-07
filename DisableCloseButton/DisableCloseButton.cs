using System;
using System.Runtime.InteropServices;

namespace SIGVerse
{
	static class DisableCloseButton
	{
		[DllImport("USER32.DLL")]
		private static extern IntPtr GetSystemMenu(IntPtr hWnd, UInt32 bRevert);

		[DllImport("USER32.DLL")]
		private static extern UInt32 RemoveMenu(IntPtr hMenu, UInt32 nPosition, UInt32 wFlags);

		[DllImport("USER32.DLL")]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		private const UInt32 SC_CLOSE = 0x0000F060;
		private const UInt32 MF_BYCOMMAND = 0x00000000;

		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				string windowName = args[0].Trim();

				IntPtr hWnd = FindWindow(null, windowName);

				if (hWnd != IntPtr.Zero)
				{
					IntPtr hMenu = GetSystemMenu(hWnd, 0);
					uint retVal = RemoveMenu(hMenu, SC_CLOSE, MF_BYCOMMAND);

					if(retVal != 0) { Console.WriteLine("Finished."); }
					else            { Console.WriteLine("Disable failed. Window Name=" + windowName); }
				}
				else
				{
					Console.WriteLine("The window was not found. Window Name="+ windowName);
				}
			}
			else
			{
				Console.WriteLine("Please set the window name as the first argument.");
			}
		}
	}
}
