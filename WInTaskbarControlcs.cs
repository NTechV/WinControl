
using Microsoft.Win32;




namespace Win11TaskbarControl
{

    public abstract class BAseclass
    {

        public abstract void taskbarsizesmall();
        public abstract void taskbarsizemedium();
        public abstract void taskbarsizelarge();


        public abstract void movetaskbartop();
        public abstract void resetsize();
        public abstract void taskbarsize(string size);
        public abstract void taskbarsize(int sizeoftaskbar); // function overload; sizeoftaskbar

        public abstract void taskbarsize(char sml); // sml stands for small medium and large
        public abstract void movetesttop();
    }

    public class maintaskbarclass : BAseclass
    {



        public override void movetaskbartop()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\StuckRects3", true);
                key.SetValue("Settings", "30 00 00 00 fe ff ff ff 02 00 00 00 01 00 00 00 00 00 3c 00 00 00 28 00 00 00 78 00 00 00 01 00 00 00 ", RegistryValueKind.Binary);
                key.Close();
            }
            catch (Exception ex) { }
        }

        public override void movetesttop()
        {
            //empty function; was planned to test the top butit doesn't work because i have to embed it to an exe project 
        }

        public override void resetsize()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                key.DeleteValue("TaskbarSi");
            }
            catch (Exception ex) { }
        }

        public void kill()
        {
            System.Diagnostics.Process ki = new System.Diagnostics.Process();
            ki.StartInfo.FileName = "h.bat"; // h.bat is to kill the proccess
            ki.Start();

        }
        public void startexplorer()
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process(); // procces I was going to orginaly name it st but the auto feature did it as proccess for me :-)
            process.StartInfo.FileName = "j.bat";
            process.Start();
        }


        public override void taskbarsize(string size)
        {
            switch (size)
            {
                case "small":
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                case "Small":
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                case "Big":
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                case "Medium":
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                default:
                    break;
            }
        }

        public override void taskbarsize(int sizeoftaskbar)
        {
            switch (sizeoftaskbar)
            {
                case 1:
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;


                case 2:
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "1", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                case 3:
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                default:
                    break;
            }
        }

        public override void taskbarsize(char sml)
        {
            switch (sml)
            {
                case 's':
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;



                case 'm':
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "1", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                case 'b':
                    try
                    {
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                        key.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);
                        key.Close();
                    }
                    catch (Exception ex) { }
                    break;
                default:
                    break;
            }
        }

        public override void taskbarsizelarge()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                key.SetValue("TaskbarSi", "2", RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex) { }

        }

        public override void taskbarsizemedium()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                key.SetValue("TaskbarSi", "1", RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex) { }
        }

        public override void taskbarsizesmall()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"HCKU\Software\Microsoft\Windows\CurrentVersion\Advanced", true);
                key.SetValue("TaskbarSi", "0", RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex) { }
        }
    }


}