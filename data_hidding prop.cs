namespace pratek
{
    class data_hidding_prop
    {
        private int _empNo;
        private string  _empName;

        public int EmpNo
        {
            set 
            {
                _empNo = value;
            }
            get
            {
             return _empNo;   
            }
        }
            public string  EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }

    }
}