﻿using System;
using System.IO;


namespace Founders
{
    public class CoreLogger
    {

        //Fields 
        static string basedir =AppDomain.CurrentDomain.BaseDirectory;
        static string logFolder = basedir + "Logs" + Path.DirectorySeparatorChar;
        
        
        //static string coinutilsLogFile = logFolder + "coinutils.log";
        //static string detectionagentLogFile = logFolder + "detectionagent.log";
        //static string detectorLogFile = logFolder + "detector.log";
        //static string dumperLogFile = logFolder + "dumper.log";
        //static string exporterLogFile = logFolder + "exporter.log";
        //static string fileutilsLogFile = logFolder + "fileutils.log";
        //static string frack_fixerLogFile = logFolder + "frack_fixer.log";
        //static string importerLogFile = logFolder + "importer.log";
        //static string raidaLogFile = logFolder + "raida.log";





        //Constructors
        

        

        static void createDir()
        {

            if (Directory.Exists(logFolder) == false)
            {
                Directory.CreateDirectory(logFolder);
            }


        }


        public static async void Log(string message, [System.Runtime.CompilerServices.CallerFilePath] string classpath = "")
        {
            string path = logFolder + "other.log";
            createDir();
            string classname = Path.GetFileNameWithoutExtension(classpath).ToLower();
            path = logFolder + classname + ".log";
            
                TextWriter tw = File.AppendText(path);
                using (tw)
                {
                    await tw.WriteLineAsync(DateTime.Now.ToLongTimeString());
                    await tw.WriteLineAsync(message);

                }
            
            
            
        }

        
    }
}
