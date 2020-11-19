using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApplication
{
    public class SamplePageViewModel
    {
        private string _loginUser;

        public string LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }

        public SamplePageViewModel(string username)
        {
            _loginUser = username;
        }
    }
}
