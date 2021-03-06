//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniWcf.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITst")]
    public interface ITst {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITst/CalculateSI", ReplyAction="http://tempuri.org/ITst/CalculateSIResponse")]
        int CalculateSI(int p, int r, int t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITst/CalculateSI", ReplyAction="http://tempuri.org/ITst/CalculateSIResponse")]
        System.Threading.Tasks.Task<int> CalculateSIAsync(int p, int r, int t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITst/GetRecordList", ReplyAction="http://tempuri.org/ITst/GetRecordListResponse")]
        System.Data.DataTable GetRecordList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITst/GetRecordList", ReplyAction="http://tempuri.org/ITst/GetRecordListResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetRecordListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITstChannel : MiniWcf.ServiceReference1.ITst, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TstClient : System.ServiceModel.ClientBase<MiniWcf.ServiceReference1.ITst>, MiniWcf.ServiceReference1.ITst {
        
        public TstClient() {
        }
        
        public TstClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TstClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TstClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TstClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CalculateSI(int p, int r, int t) {
            return base.Channel.CalculateSI(p, r, t);
        }
        
        public System.Threading.Tasks.Task<int> CalculateSIAsync(int p, int r, int t) {
            return base.Channel.CalculateSIAsync(p, r, t);
        }
        
        public System.Data.DataTable GetRecordList() {
            return base.Channel.GetRecordList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetRecordListAsync() {
            return base.Channel.GetRecordListAsync();
        }
    }
}
