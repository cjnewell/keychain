using System;
using System.Collections.Generic;
using Keychain.Input;
using Keychain;

namespace Keychain
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordDictionary dictionary = new PasswordDictionary();
            Dictionary<string, Command> commandMap = new Dictionary<string, Command>();

            commandMap.Add("add", new AddCommand());
            commandMap.Add("help", new HelpCommand());
            commandMap.Add("remove", new RemoveCommand());
            commandMap.Add("update", new UpdateCommand());

            while (true) {
                Console.Write("Cmd: ");
                string cmd = Console.ReadLine();
                Tokens tokens = new Tokens(cmd);
            
            
                commandMap[$"{tokens.advance()}"].Run(tokens, dictionary);
            }

        }
    }
}
