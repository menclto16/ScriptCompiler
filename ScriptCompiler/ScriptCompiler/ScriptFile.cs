using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis;

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

        public async void RunScript(Character character)
        {
            var metadata = MetadataReference.CreateFromFile(character.GetType().Assembly.Location);

            var scriptOptions = ScriptOptions.Default.WithReferences(metadata).WithImports(GetType().Namespace);

            var returnValue = await CSharpScript.EvaluateAsync(Content, options: scriptOptions, globals: character);

            ReturnValue = returnValue.ToString();
        }
    }
}
