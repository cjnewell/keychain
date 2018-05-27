using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain {

    class Command {

        private string mName;

        public string Id {
            get { return mName; }
            set { mName = value; }
        }

        public Command(string xName) {
            Id = xName;
        }

        public virtual void Run(Tokens xTokens, PasswordDictionary xDictionary) { }
    }
}
