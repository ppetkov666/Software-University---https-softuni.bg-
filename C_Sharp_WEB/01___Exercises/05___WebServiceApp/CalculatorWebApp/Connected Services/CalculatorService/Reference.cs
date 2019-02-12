﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApp.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://petkopetkov.org/webservices", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://petkopetkov.org/webservices", ConfigurationName="CalculatorService.CalculatorWebServiceSoap")]
    public interface CalculatorWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://petkopetkov.org/webservices/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://petkopetkov.org/webservices/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://petkopetkov.org/webservices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://petkopetkov.org/webservices/GetCalculations", ReplyAction="*")]
        CalculatorWebApp.CalculatorService.GetCalculationsResponse GetCalculations(CalculatorWebApp.CalculatorService.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://petkopetkov.org/webservices/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalculationsResponse> GetCalculationsAsync(CalculatorWebApp.CalculatorService.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://petkopetkov.org/webservices", Order=0)]
        public CalculatorWebApp.CalculatorService.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(CalculatorWebApp.CalculatorService.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://petkopetkov.org/webservices", Order=0)]
        public CalculatorWebApp.CalculatorService.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(CalculatorWebApp.CalculatorService.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://petkopetkov.org/webservices")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorWebApp.CalculatorService.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(CalculatorWebApp.CalculatorService.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServiceSoapChannel : CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServiceSoapClient : System.ServiceModel.ClientBase<CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap>, CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap {
        
        public CalculatorWebServiceSoapClient() {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApp.CalculatorService.GetCalculationsResponse CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap.GetCalculations(CalculatorWebApp.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public CalculatorWebApp.CalculatorService.ArrayOfString GetCalculations() {
            CalculatorWebApp.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApp.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.GetCalculationsRequestBody();
            CalculatorWebApp.CalculatorService.GetCalculationsResponse retVal = ((CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalculationsResponse> CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap.GetCalculationsAsync(CalculatorWebApp.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApp.CalculatorService.GetCalculationsResponse> GetCalculationsAsync() {
            CalculatorWebApp.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApp.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApp.CalculatorService.GetCalculationsRequestBody();
            return ((CalculatorWebApp.CalculatorService.CalculatorWebServiceSoap)(this)).GetCalculationsAsync(inValue);
        }
    }
}