using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ScriptCompiler
{
    class ScriptApp
    {
        public List<ScriptFile> ScriptFiles = new List<ScriptFile>();

        public void AddScriptFiles(List<string> filenames)
        {
            foreach (var filename in filenames)
            {
                bool exists = false;
                foreach (var scriptFile in ScriptFiles)
                {
                    if (filename == scriptFile.FileName) exists = true;
                }

                if (!exists)
                {
                    string fileContent = File.ReadAllText(filename);
                    ScriptFiles.Add(new ScriptFile(filename, fileContent));
                }
            }
        }

        public List<string> RunAll(Character character)
        {
            List<string> returnValues = new List<string>();
            foreach (var scriptFile in ScriptFiles)
            {
                scriptFile.RunScript(character);
                returnValues.Add(scriptFile.ReturnValue);
            }

            return returnValues;
        }
    }
}
