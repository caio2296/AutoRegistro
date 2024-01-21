using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Token
{
    public static class ApplicationState
    {
        private static TokenData _tokenData;

        public static TokenData TokenData
        {
            get { return _tokenData; }
            set { _tokenData = value; }
        }
    }
}
