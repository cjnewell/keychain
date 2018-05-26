using System;
using System.Collections.Generic;
using System.Text;

namespace Keychain {
    class PasswordDictionary {
        private Dictionary<String, LogEntry> mKeychain;

        public PasswordDictionary() {
            mKeychain = new Dictionary<string, LogEntry>();
        }

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
                isModified = true;
                LogEntry entry = mKeychain[xServiceName];
                entry.setPassword(xPassword);
            }

            return isModified;
        }

        public String toString() {
            StringBuilder log = new StringBuilder();

            foreach (KeyValuePair<String, LogEntry> entry in mKeychain) {
                log.Append(entry.Key).Append("\t").Append(entry.Value.getPassword());
            }

            return log.ToString();
        }


    }
}
