using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain {

    class HelpCommand : Command {

        public HelpCommand() : base("help") {
        }

        public override void Run(Tokens xTokens, PasswordDictionary xDictionary) {
            Console.WriteLine("HelpCommand!");
        }
    }
}
