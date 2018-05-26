using System;
using System.Collections.Generic;
using System.Text;
using Keychain.Input;

namespace Keychain.Action {

    class Action {

        private string mName;

        public string Id {
            get { return mName; }
            set { mName = value; }
        }

        public Action(string xName) {
            Id = xName;
        }

        public virtual void Run(Tokens xTokens, PasswordDictionary xDictionary) { }
    }
}
