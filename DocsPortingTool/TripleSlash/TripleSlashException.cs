﻿using System.Xml.Linq;

namespace DocsPortingTool.TripleSlash
{
    public class TripleSlashException
    {
        public XElement XEException
        {
            get;
            private set;
        }

        private string _cref = string.Empty;
        public string Cref
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_cref))
                {
                    _cref = XmlHelper.GetAttributeValue(XEException, "cref");
                }
                return _cref;
            }
        }

        private string _value = string.Empty;
        public string Value
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_value))
                {
                    _value = XmlHelper.GetRealValue(XEException);
                }
                return _value;
            }
        }

        public TripleSlashException(XElement xeException)
        {
            XEException = xeException;
        }
    }
}
