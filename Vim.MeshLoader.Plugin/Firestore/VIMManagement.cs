using Newtonsoft.Json;
using System;
using System.IO;
using Vim.MeshLoader.Plugin.Models;

namespace Vim.MeshLoader.Plugin
{
    internal class VIMManagement
    {
        internal static void SaveCurrentModel(Rootobject obj)
        {
            throw new NotImplementedException();
        }

        internal static void ProcessRemoteChanges(Rootobject rootObject)
        {
            throw new NotImplementedException();
        }

        internal static void SaveCurrentModel(string st)
        {
            using (var file = File.CreateText(FileManager.getJson3DPath()))
            {
                file.Write(st);
            }

            var path = FileManager.getJson3DPath();

            MeshLoader.LoadVa3CFile(path);

        }
    }
}