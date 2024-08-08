using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Test
{
    abstract class LibraryResource
    {
        string _name_;
        bool _onLoan_;
        public LibraryResource(string name)
        {
            _name_ = name;
        }
        public string Name
        {
            get
            {
                return _name_;
            }
        }
        public bool OnLoan
        {
            get
            {
                return _onLoan_;
            }
            set
            {
                _onLoan_ = false;
            }
        }
        abstract public string Developer
        {
            get;
        }


    }
}

//Tran Quoc Dung 103803891 