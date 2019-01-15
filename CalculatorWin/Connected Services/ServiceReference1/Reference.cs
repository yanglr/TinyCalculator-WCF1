﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWin.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://by.me", ConfigurationName="ServiceReference1.IMath")]
    public interface IMath {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Multiply", ReplyAction="http://by.me/IMath/MultiplyResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.OverflowException), Action="http://by.me/IMath/MultiplyOverflowExceptionFault", Name="OverflowException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        int Multiply(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Multiply", ReplyAction="http://by.me/IMath/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/MultiplyDouble", ReplyAction="http://by.me/IMath/MultiplyDoubleResponse")]
        double MultiplyDouble(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/MultiplyDouble", ReplyAction="http://by.me/IMath/MultiplyDoubleResponse")]
        System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Divide", ReplyAction="http://by.me/IMath/DivideResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.DivideByZeroException), Action="http://by.me/IMath/DivideDivideByZeroExceptionFault", Name="DivideByZeroException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        int Divide(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Divide", ReplyAction="http://by.me/IMath/DivideResponse")]
        System.Threading.Tasks.Task<int> DivideAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/DivideDouble", ReplyAction="http://by.me/IMath/DivideDoubleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.DivideByZeroException), Action="http://by.me/IMath/DivideDoubleDivideByZeroExceptionFault", Name="DivideByZeroException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        double DivideDouble(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/DivideDouble", ReplyAction="http://by.me/IMath/DivideDoubleResponse")]
        System.Threading.Tasks.Task<double> DivideDoubleAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Add", ReplyAction="http://by.me/IMath/AddResponse")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Add", ReplyAction="http://by.me/IMath/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/AddDouble", ReplyAction="http://by.me/IMath/AddDoubleResponse")]
        double AddDouble(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/AddDouble", ReplyAction="http://by.me/IMath/AddDoubleResponse")]
        System.Threading.Tasks.Task<double> AddDoubleAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Subtract", ReplyAction="http://by.me/IMath/SubtractResponse")]
        int Subtract(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/Subtract", ReplyAction="http://by.me/IMath/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/SubtractDouble", ReplyAction="http://by.me/IMath/SubtractDoubleResponse")]
        double SubtractDouble(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://by.me/IMath/SubtractDouble", ReplyAction="http://by.me/IMath/SubtractDoubleResponse")]
        System.Threading.Tasks.Task<double> SubtractDoubleAsync(double x, double y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathChannel : CalculatorWin.ServiceReference1.IMath, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathClient : System.ServiceModel.ClientBase<CalculatorWin.ServiceReference1.IMath>, CalculatorWin.ServiceReference1.IMath {
        
        public MathClient() {
        }
        
        public MathClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Multiply(int x, int y) {
            return base.Channel.Multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y) {
            return base.Channel.MultiplyAsync(x, y);
        }
        
        public double MultiplyDouble(double x, double y) {
            return base.Channel.MultiplyDouble(x, y);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyDoubleAsync(double x, double y) {
            return base.Channel.MultiplyDoubleAsync(x, y);
        }
        
        public int Divide(int x, int y) {
            return base.Channel.Divide(x, y);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int x, int y) {
            return base.Channel.DivideAsync(x, y);
        }
        
        public double DivideDouble(double x, double y) {
            return base.Channel.DivideDouble(x, y);
        }
        
        public System.Threading.Tasks.Task<double> DivideDoubleAsync(double x, double y) {
            return base.Channel.DivideDoubleAsync(x, y);
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public double AddDouble(double x, double y) {
            return base.Channel.AddDouble(x, y);
        }
        
        public System.Threading.Tasks.Task<double> AddDoubleAsync(double x, double y) {
            return base.Channel.AddDoubleAsync(x, y);
        }
        
        public int Subtract(int x, int y) {
            return base.Channel.Subtract(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int x, int y) {
            return base.Channel.SubtractAsync(x, y);
        }
        
        public double SubtractDouble(double x, double y) {
            return base.Channel.SubtractDouble(x, y);
        }
        
        public System.Threading.Tasks.Task<double> SubtractDoubleAsync(double x, double y) {
            return base.Channel.SubtractDoubleAsync(x, y);
        }
    }
}
