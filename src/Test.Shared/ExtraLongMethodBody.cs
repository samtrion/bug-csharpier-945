namespace Test.Shared;

using System.Text;

public static class ExtraLongMethodBody
{
    public static void Call(StringBuilder sb)
    {
        sb.Append("Hello").Append(" ").Append("World").Append(",").Append(" ").Append("from").Append("Shared").Append(" ").Append("Module").AppendLine("!");

        // Expected:
        // sb.Append("Hello")
        //     .Append(" ")
        //     .Append("World")
        //     .Append(",")
        //     .Append(" ")
        //     .Append("from")
        //     .Append(" ")
        //     .Append("Shared")
        //     .Append(" ")
        //     .Append("Module")
        //     .AppendLine("!");
    }
}