using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain {

    class AddCommand : Command {

        public AddCommand() : base("add") {
        }

        public override void Run(Tokens xTokens, PasswordDictionary xDictionary) {
            Console.WriteLine("AddCommand!");
        }
    }
}
