using System;
using System.Collections.Generic;
using System.Text;

namespace Keychain.Input {

    class Tokens {
        private Queue<String> mTokens;

        public Tokens(String xCmdLine) {
            mTokens = new Queue<string>();
            String[] lineItems = xCmdLine.Split(' ');

            for (int ii = 0; ii < lineItems.Length; ++ii) {
                mTokens.Enqueue(lineItems[ii]);
            }
        }

        public String advance() {
            return mTokens.Dequeue();
        }

        public bool isEmpty() {
            return mTokens.Count == 0;
        }


    }
}
