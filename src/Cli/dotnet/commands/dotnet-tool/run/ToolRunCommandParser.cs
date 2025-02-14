// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using Microsoft.DotNet.Tools.Tool.Run;
using LocalizableStrings = Microsoft.DotNet.Tools.Tool.Run.LocalizableStrings;

namespace Microsoft.DotNet.Cli
{
    internal static class ToolRunCommandParser
    {
        public static readonly Argument<string> CommandNameArgument = new Argument<string>(LocalizableStrings.CommandNameArgumentName)
        {
            Description = LocalizableStrings.CommandNameArgumentDescription
        };

        private static readonly Command Command = ConstructCommand();

        public static Command GetCommand()
        {
            return Command;
        }

        private static Command ConstructCommand()
        {
            var command = new Command("run", LocalizableStrings.CommandDescription);

            command.AddArgument(CommandNameArgument);
            command.TreatUnmatchedTokensAsErrors = false;

            command.SetHandler((parseResult) => new ToolRunCommand(parseResult).Execute());

            return command;
        }
    }
}
