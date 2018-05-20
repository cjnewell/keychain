using System;
using System.Collections.Generic;
using System.Text;

namespace Keychain {
    class PasswordDictionary {
        private Dictionary<String, LogEntry> mKeychain;

        public bool addPassword(LogEntry xEntry) {
            String key = xEntry.getService();
            bool addSuccessful = false;

            if (!mKeychain.ContainsKey(key)) {
                addSuccessful = true;
                mKeychain.Add(key, xEntry);
            }

            return addSuccessful;
        }

        public bool removePassword(String xServiceName) {
            bool removeSuccessful = false;

            if (mKeychain.ContainsKey(xServiceName)) {
                removeSuccessful = true;
                mKeychain.Remove(xServiceName);
            }

            return removeSuccessful;
        }

        public bool modifyPassword(String xServiceName, String xPassword) {
            bool isModified = false;

            if (mKeychain.ContainsKey(xServiceName)) {
                LogEntry entry = mKeychain[xServiceName];
                entry.setPassword(xPassword);
            }
        }

    }
}
