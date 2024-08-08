using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventure.Abstract
{
    public class IdentifiableObject
    {
        private readonly List<string> _identifiers = new List<string>();
        private readonly string id;

        public IdentifiableObject(string[] idents)
        {
            foreach (string ident in idents)
            {
                _identifiers.Add(ident);
            }
        }

        public bool AreYou(string id)
        {
            return _identifiers.Contains(id, StringComparer.OrdinalIgnoreCase);
        }

        public string FirstId
        {

            get
            {
                string identifier = "";
                if (_identifiers.Count != 0)
                {
                    identifier = _identifiers[0];
                }
                return identifier;
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}

//Tran Quoc Dung 103803891