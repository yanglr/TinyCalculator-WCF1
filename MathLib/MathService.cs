using System;
using System.ServiceModel;

namespace MathLib
{
    [ServiceContract(Namespace = "http://by.me")]
    public interface IMath
    {
        [OperationContract]
        [FaultContract(typeof(OverflowException))]
        int Multiply(int x, int y);
        [OperationContract(Name = "MultiplyDouble")]
        double Multiply(double x, double y);
        [OperationContract]
        [FaultContract(typeof(DivideByZeroException))]
        int Divide(int x, int y);
        [OperationContract(Name = "DivideDouble")]
        [FaultContract(typeof(DivideByZeroException))]
        double Divide(double x, double y);

        [OperationContract]
        int Add(int x, int y);
        [OperationContract(Name = "AddDouble")]
        double Add(double x, double y);

        [OperationContract]
        int Subtract(int x, int y);
        [OperationContract(Name = "SubtractDouble")]
        double Subtract(double x, double y);
    }

#if DEBUG
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
#endif
    public class MathService:IMath
    {
        public int Multiply(int x, int y)
        {
            int result = 0;
            try
            {
                result = checked(x * y);
            }
            catch(OverflowException ex)
            {
                ex = new OverflowException();
                throw new FaultException<OverflowException>(
                    ex, "Integer overflow in multiplication");
            }
            return result;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            if(y == 0)
            {
                DivideByZeroException ex = new DivideByZeroException();
                throw new FaultException<DivideByZeroException>(
                    ex, "Attempted to divide by zero");
            }
            return x / y;
        }
        public double Divide(double x, double y)
        {
            if(y == 0)
            {
                DivideByZeroException ex = new DivideByZeroException();
                throw new FaultException<DivideByZeroException>(
                    ex, "Attempted to divide by zero");
            }
            return x / y;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
