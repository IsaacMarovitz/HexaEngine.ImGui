﻿namespace Generator
{
    public sealed class CodeWriter : IDisposable
    {
        private bool _shouldIndent = true;
        private readonly string[] _indentStrings;
        private string _indentString = "";
        private readonly StreamWriter _writer;

        public int IndentLevel { get; private set; }

        public CodeWriter(string fileName, params string[] namespaces)
        {
            _indentStrings = new string[10];
            for (int i = 0; i < _indentStrings.Length; i++)
            {
                _indentStrings[i] = new string('\t', i);
            }

            _writer = File.CreateText(fileName);
            _writer.WriteLine("// ------------------------------------------------------------------------------");
            _writer.WriteLine("// <auto-generated>");
            _writer.WriteLine("//     This code was generated by a tool.");
            _writer.WriteLine("//");
            _writer.WriteLine("//     Changes to this file may cause incorrect behavior and will be lost if");
            _writer.WriteLine("//     the code is regenerated.");
            _writer.WriteLine("// </auto-generated>");
            _writer.WriteLine("// ------------------------------------------------------------------------------");
            _writer.WriteLine();

            foreach (var ns in namespaces)
            {
                _writer.WriteLine($"using {ns};");
            }

            if (namespaces.Length > 0)
            {
                _writer.WriteLine();
            }

            BeginBlock($"namespace {CsCodeGeneratorSettings.Default.Namespace}");
        }

        public void Dispose()
        {
            EndBlock();
            _writer.Dispose();
        }

        public void Write(char chr)
        {
            WriteIndented(chr);
        }

        public void Write(string @string)
        {
            WriteIndented(@string);
        }

        public void WriteLine()
        {
            _writer.WriteLine();
            _shouldIndent = true;
        }

        public void WriteLine(string @string)
        {
            WriteIndented(@string);
            _writer.WriteLine();
            _shouldIndent = true;
        }

        public void BeginBlock(string content)
        {
            WriteLine(content);
            WriteLine("{");
            Indent(1);
        }

        public void EndBlock()
        {
            Dedent(1);
            WriteLine("}");
        }

        public IDisposable PushBlock(string marker = "{") => new CodeBlock(this, marker);

        public void Indent(int count = 1)
        {
            IndentLevel += count;

            if (IndentLevel < _indentStrings.Length)
            {
                _indentString = _indentStrings[IndentLevel];
            }
            else
            {
                _indentString = new string('\t', IndentLevel);
            }
        }

        public void Dedent(int count = 1)
        {
            if (count > IndentLevel)
                throw new ArgumentException("count out of range.", nameof(count));

            IndentLevel -= count;
            if (IndentLevel < _indentStrings.Length)
            {
                _indentString = _indentStrings[IndentLevel];
            }
            else
            {
                _indentString = new string('\t', IndentLevel);
            }
        }

        private void WriteIndented(char chr)
        {
            if (_shouldIndent)
            {
                _writer.Write(_indentString);
                _shouldIndent = false;
            }

            _writer.Write(chr);
        }

        private void WriteIndented(string @string)
        {
            if (_shouldIndent)
            {
                _writer.Write(_indentString);
                _shouldIndent = false;
            }

            _writer.Write(@string);
        }

        private class CodeBlock : IDisposable
        {
            private readonly CodeWriter _writer;

            public CodeBlock(CodeWriter writer, string content)
            {
                _writer = writer;
                _writer.BeginBlock(content);
            }

            public void Dispose()
            {
                _writer.EndBlock();
            }
        }

    }
}
