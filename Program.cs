using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharStream stream = CharStreams.fromPath(args[0]);
            ITokenSource lexer = new YARSpgLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            YARSpgParser parser = new YARSpgParser(tokens);
            parser.BuildParseTree = true;
            IParseTree tree = parser.yarspg();
        }
    }
}
