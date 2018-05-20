using System;
using System.Collections.Generic;
using System.Text;

namespace Keychain {

    class LogEntry {
        private String mService;
        private String mUser;
        private String mPassword;

        public LogEntry() {
            mService = "";
            mUser = "";
            mPassword = "";
        }

        public void setService(String xService) {
            mService = xService;
        }

        public void setUser(String xUser) {
            mUser = xUser;
        }

        public void setPassword(String xPassword) {
            mPassword = xPassword;
        }

        public String getService() {
            return mService;
        }

        public String getUser() {
            return mUser;
        }

        public String getPassword() {
            return mPassword;
        }

    }
}
