//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//---------------------------------------- 
using System.Text;

namespace Lumpn.Discord.Utils
{
    public static class JsonUtils
    {
        public static string Escape(string str)
        {
            var sb = new StringBuilder();
            AppendJson(sb, str);
            return sb.ToString();
        }

        public static void AppendJson(StringBuilder sb, string str)
        {
            foreach (var c in str)
            {
                switch (c)
                {
                    case '\b': // 8
                        sb.Append("\\b");
                        break;
                    case '\t': // 9
                        sb.Append("\\t");
                        break;
                    case '\n': // 10
                        sb.Append("\\n");
                        break;
                    case '\f': // 12
                        sb.Append("\\f");
                        break;
                    case '\r': // 13
                        sb.Append("\\r");
                        break;
                    case '"': // 34
                        sb.Append("\\\"");
                        break;
                    case '/': // 47
                        sb.Append("\\/");
                        break;
                    case '\\': // 92
                        sb.Append("\\\\");
                        break;
                    default:
                        sb.Append(c);
                        break;
                }
            }
        }
    }
}
