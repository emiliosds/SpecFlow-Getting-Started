namespace Example
{
    public class Calculator
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int Addition()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtraction()
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiplication()
        {
            return FirstNumber * SecondNumber;
        }

        public int Division()
        {
            if (FirstNumber == 0 || SecondNumber == 0)
                return 0;

            return FirstNumber / SecondNumber;
        }
    }
}