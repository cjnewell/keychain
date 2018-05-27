using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain {

    class UpdateCommand : Command {

        public UpdateCommand() : base("update") {
        }

        public override void Run(Tokens xTokens, PasswordDictionary xDictionary) {
            Console.WriteLine("UpdateCommand!");
        }
    }
}
