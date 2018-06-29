using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace EC_Ikcadm.Tool.Systen
{
    public class Tstask
    {
        //Verificador de processos web
        public static Boolean TaskManagerBrowser(string browser, string webdriver)
        {
            bool obj = false;

            List<string> lstProcess = new List<string>();
            Process[] myProcs = Process.GetProcesses();

            foreach (var item in myProcs)
            {
                lstProcess.Add(item.ProcessName);
            }

            if (lstProcess.Contains(browser) && lstProcess.Contains(webdriver))
            {
                obj = true;
            }

            return obj;
        }

        //Encerrador de processos 
        public static void TaskKill(string process)
        {
            Process[] myProcs = Process.GetProcesses();

            foreach (var item in myProcs)
            {
                if (item.ProcessName == process)
                {
                    item.Kill();
                }
            }
        }
    }
}