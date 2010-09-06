using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.Configuration;
using System.Security.Principal;
using System.Collections;

namespace TietoVNCServerStarter
{
    /// <summary>
    /// Class for creating user data
    /// </summary>
    public class UserData
    {
        private WindowsIdentity _identity;
        private SecurityIdentifier _sidIdentifier;
        private string _userName;
        private string _eMail;
        private string _userSID;

        #region Constructor
        public UserData()
        {
            Initialize();
        }
        #endregion Constructor

        #region Properties
        /// <summary>
        /// gets user E-mail address
        /// </summary>
        public string EMail
        {
            get { return _eMail; }
        }

        /// <summary>
        /// gets user name
        /// </summary>
        public string UserName
        {
            get { return _userName; }
        }

        /// <summary>
        /// Gets user SID
        /// </summary>
        public string UserSID
        {
            get { return _userSID; }
        }
        #endregion Properties

        #region Implementation
        private void Initialize()
        {
            //get current user information
            _identity = WindowsIdentity.GetCurrent();
            _userName = _identity.Name;
            _sidIdentifier = _identity.User;
            _userSID = _sidIdentifier.Value;

            try
            {
                _eMail = GetEmailAddress();
            }
            catch (Exception e)
            {
                string message = "User E-Mail could not be fetched from Aktive Directory. ";
                message = message + e.Message;
                Logger.Log.Error(message);
            }
        }

        private string GetEmailAddress()
        {
            string retval = string.Empty;
            int indOf = _userName.IndexOf('\\');
            string domainName = _userName.Substring(0, indOf);
            _userName = _userName.Substring(indOf + 1);
            domainName = "LDAP://" + domainName;

            using ( DirectoryEntry domain = new DirectoryEntry(domainName))
            {
                using (DirectorySearcher searcher = new DirectorySearcher(domain))
                {
                    searcher.Filter = "(samaccountname=" + _userName + ")";
                    SearchResult result = searcher.FindOne();

                    string property = "mail";

                    retval = GetProperty(result, property);
                }
            }
            return retval;
        }




        private string GetProperty(SearchResult searchResult, string PropertyName)
        {
            if (searchResult.Properties.Contains(PropertyName))
            {
                return searchResult.Properties[PropertyName][0].ToString();
            }
            else
            {
                return string.Empty;
            }
        }
        #endregion Implementation
    }
}
