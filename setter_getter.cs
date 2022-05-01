using System;
namespace setget
{
    class setter_getter
    {
        private int _no;
        private string _name;


            public void SetNo(int _no)
            {
               this._no = _no;
            }
            public int  GetNo()
            {
            return _no;
            }
        public void SetName(string  _name)
        {
            this._name = _name;
        }
        public string  GetName()
        {
            return _name;
        }

    }
     
           
 }

