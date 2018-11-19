using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ScriptCompiler
{
    class ScriptFile
    {
        public string FileName;
        public string Content;
        public string ReturnValue;

        public ScriptFile(string filename, string content)
        {
            FileName = filename;
            Content = content;
        }

        public async void RunScript(ICharacter character)
        {
            var returnValue = await CSharpScript.EvaluateAsync(Content, globals: character, globalsType: typeof(ICharacter));

            ReturnValue = returnValue.ToString();
        }
    }
}
