namespace MyNamespace
{
    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _baseString = "Base+Derived";
        }

        public override string BaseString
        {

            get
            {
                return _baseString;
            }
            
        }
    }
}