using System.Text;
using Test.Shared;

var sb = new StringBuilder();

sb.Append("Hello")
    .Append(" ")
    .Append("World")
    .Append(",")
    .Append(" ")
    .Append("from")
    .Append(" ")
    .Append("Console")
    .AppendLine("!");

ExtraLongMethodBody.Call(sb);

Console.WriteLine(sb.ToString());
