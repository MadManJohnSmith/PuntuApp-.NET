﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://CompLogin/", ConfigurationName="ServiceReference1.Auth")]
    public interface Auth {
        
        // CODEGEN: Generating message contract since element name username from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://CompLogin/Auth/validarUsuarioRequest", ReplyAction="http://CompLogin/Auth/validarUsuarioResponse")]
        WindowsFormsApp1.ServiceReference1.validarUsuarioResponse validarUsuario(WindowsFormsApp1.ServiceReference1.validarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CompLogin/Auth/validarUsuarioRequest", ReplyAction="http://CompLogin/Auth/validarUsuarioResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(WindowsFormsApp1.ServiceReference1.validarUsuarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuario", Namespace="http://CompLogin/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.validarUsuarioRequestBody Body;
        
        public validarUsuarioRequest() {
        }
        
        public validarUsuarioRequest(WindowsFormsApp1.ServiceReference1.validarUsuarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class validarUsuarioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public validarUsuarioRequestBody() {
        }
        
        public validarUsuarioRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class validarUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="validarUsuarioResponse", Namespace="http://CompLogin/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.validarUsuarioResponseBody Body;
        
        public validarUsuarioResponse() {
        }
        
        public validarUsuarioResponse(WindowsFormsApp1.ServiceReference1.validarUsuarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class validarUsuarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public validarUsuarioResponseBody() {
        }
        
        public validarUsuarioResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthChannel : WindowsFormsApp1.ServiceReference1.Auth, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.Auth>, WindowsFormsApp1.ServiceReference1.Auth {
        
        public AuthClient() {
        }
        
        public AuthClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.validarUsuarioResponse WindowsFormsApp1.ServiceReference1.Auth.validarUsuario(WindowsFormsApp1.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuario(request);
        }
        
        public string validarUsuario(string username, string password) {
            WindowsFormsApp1.ServiceReference1.validarUsuarioRequest inValue = new WindowsFormsApp1.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            WindowsFormsApp1.ServiceReference1.validarUsuarioResponse retVal = ((WindowsFormsApp1.ServiceReference1.Auth)(this)).validarUsuario(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.validarUsuarioResponse> WindowsFormsApp1.ServiceReference1.Auth.validarUsuarioAsync(WindowsFormsApp1.ServiceReference1.validarUsuarioRequest request) {
            return base.Channel.validarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.validarUsuarioResponse> validarUsuarioAsync(string username, string password) {
            WindowsFormsApp1.ServiceReference1.validarUsuarioRequest inValue = new WindowsFormsApp1.ServiceReference1.validarUsuarioRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.validarUsuarioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((WindowsFormsApp1.ServiceReference1.Auth)(this)).validarUsuarioAsync(inValue);
        }
    }
}