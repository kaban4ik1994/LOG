using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Command_Line
{
    public abstract class CommandLine
    {
        public static Dictionary<string, string> Pars(IEnumerable<string> line)
        {
            var tempDictionary = new Dictionary<string, string>();
            var arrayLine = line.ToArray();

            if (!IsCommandsCorrect(arrayLine) || !arrayLine.Any()) return tempDictionary;

            foreach (var command in arrayLine)
            {
                tempDictionary.Add(command.Split('=')[0].Remove(0, 2), command.Split('=')[1]);
            }
            return tempDictionary;
        }

        private static bool IsCommandsCorrect(IEnumerable<string> commands)
        {
            const string pattern = @"\-\-\w+\=\w+";
            var regex = new Regex(pattern);
            var result = commands.Where(n => regex.Match(n).Success == false);
            return !result.Any();
        }
    }
}

