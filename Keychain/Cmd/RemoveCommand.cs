using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain {

    class RemoveCommand : Command {

        public RemoveCommand() : base("remove") {
        }

        public override void Run(Tokens xTokens, PasswordDictionary xDictionary) {
            Console.WriteLine("RemoveCommand!");
        }
    }
}
