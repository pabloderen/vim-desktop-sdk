﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using System.Reflection;

namespace Vim.MeshLoader.Plugin
{
    class FileManager
    {

        public static string getModelName()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            string path = Directory.GetParent(s) + "\\model.txt";
            using (StreamReader file = new StreamReader(path))
            {
                return file.ReadToEnd();
            }

        }

        public static string getJson3DPath()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            string path = Directory.GetParent(s) + "\\BIMSocket.json";
            return path;
        }

        public static string getVIMPath()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            string path = Directory.GetParent(s) + "\\BIMSocket.vim";
            return path;
        }

        public static string getCredentialsPath()
        {
            var s = Assembly.GetExecutingAssembly().Location;
            string path = Directory.GetParent(s) + "\\credentials.json";
            return path;
        }

        public void SaveFileTo(List<String> lines)
        {
            var filePath = FileManager.getJson3DPath();
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                if (lines.Count != 0) //Error Handling
                {
                    foreach (String s in lines)
                    {
                        writer.WriteLine(s);
                    }
                }
            }

        }

        public static string ReadJsonFile()
        {
            string jsonString;
            using (StreamReader streamReader = new StreamReader(getJson3DPath()))
            {
                jsonString = streamReader.ReadToEnd();
            }

            return jsonString;
        }

    }
}
