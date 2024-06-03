using System.Diagnostics;
using System.Runtime.InteropServices;

namespace hider;

class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
    
    static void Main()
    {
        while (true)
        {
            bool a = HideEverything();
            if (!a)
            {
                return;
            }
            Thread.Sleep(1000);
        }
    }
    
    private static bool HideEverything()
    {
        //check open minecraft
        try
        {
            var proc_javaw = Process.GetProcessesByName("javaw").Any() ? "процесс существует" : "процесс не существует";
            if (proc_javaw == "процесс не существует")
            {
                var proc_java = Process.GetProcessesByName("java").Any() ? "процесс существует" : "процесс не существует";
                if (proc_java == "процесс не существует")
                    return false;
                else
                {
                    
                }
            }
        }
        catch (Exception e)
        {
            return false;
            throw;
        }
        //Everything Bypass
        try
        {
            foreach (var proc in Process.GetProcessesByName("Everything"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Ваш компьютер не поддерживает Everything!", "Everything", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }
        //ShellBag Bypass
        try
        {
            foreach (var proc in Process.GetProcessesByName("shellbag_analyzer_cleaner"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Произошла неизвестная ошибка! Код ошибки: 01x4562", "ShallBag", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }
        //Browser Bypass
        try
        {
            foreach (var proc in Process.GetProcessesByName("brave"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Браузер заблокирован Родительским контролем", "Family Link", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }
        try
        {
            foreach (var proc in Process.GetProcessesByName("browser"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Браузер заблокирован Родительским контролем", "Family Link", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }
        try
        {
            foreach (var proc in Process.GetProcessesByName("chrome"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Браузер заблокирован Родительским контролем", "Family Link", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }
        //ProcessHacker Bypass
        try
        {
            foreach (var proc in Process.GetProcessesByName("ProcessHacker"))
            {
                proc.Kill();
                MessageBox(new IntPtr(0), "Неизвестное приложение. Для разблокировки обратитесь к родителю.", "Family Link", 0);
            }
        }
        catch (Exception e)
        {
            //Console.WriteLine(e);
            throw;
        }

        return true;
    }
}