using System;
using System.IO;

namespace WrapperGenerator.Helper
{
    public class Repo
    {
        public static bool ContainsSolution(string path)
        {
            foreach (var file in Directory.EnumerateFiles(path))
            {
                if (file.EndsWith(".sln"))
                    return true;
            }

            return false;
        }

        public static bool IsRepoRoot(string path) {
            foreach (var dir in Directory.EnumerateDirectories(path)) {
                if (dir == ".git")
                    return true;
            }

            return false;
        }

        public static string GetRepoRoot() {
            var path = Environment.CurrentDirectory;

            while(!ContainsSolution(path))
                path = Directory.GetParent(path)?.FullName ?? throw new Exception("Can't find repo root");

            return path;
        }
    }
}