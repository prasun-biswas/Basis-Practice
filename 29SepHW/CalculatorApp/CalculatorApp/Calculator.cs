namespace CalculatorApp
{
    class Calculator

    {
        
        public double Add(double firstNo, double secondNo)
        {
            return firstNo + secondNo;
        }

        //public double Add(double firstNo, double secondNo, double thirdNo)
        //{
        //    return Add(Add(firstNo, secondNo), thirdNo);
        //}

        public double Subtract(double firstNo, double secondNo)
        {
            return firstNo - secondNo;
        }

        public double Multiply(double firstNo, double secondNo)
        {
            return firstNo * secondNo;
        }

        public double Divide(double firstNo, double secondNo)
        {
            return firstNo / secondNo;
        }

    }
}
