﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientTest.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="userbilgi", Namespace="http://schemas.datacontract.org/2004/07/appservice")]
    [System.SerializableAttribute()]
    public partial class userbilgi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int coinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] imageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int coin {
            get {
                return this.coinField;
            }
            set {
                if ((this.coinField.Equals(value) != true)) {
                    this.coinField = value;
                    this.RaisePropertyChanged("coin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] image {
            get {
                return this.imageField;
            }
            set {
                if ((object.ReferenceEquals(this.imageField, value) != true)) {
                    this.imageField = value;
                    this.RaisePropertyChanged("image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="konumbilgi", Namespace="http://schemas.datacontract.org/2004/07/appservice")]
    [System.SerializableAttribute()]
    public partial class konumbilgi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aciklamaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string adresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gonderenusernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string xField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string yField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aciklama {
            get {
                return this.aciklamaField;
            }
            set {
                if ((object.ReferenceEquals(this.aciklamaField, value) != true)) {
                    this.aciklamaField = value;
                    this.RaisePropertyChanged("aciklama");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string adres {
            get {
                return this.adresField;
            }
            set {
                if ((object.ReferenceEquals(this.adresField, value) != true)) {
                    this.adresField = value;
                    this.RaisePropertyChanged("adres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gonderenusername {
            get {
                return this.gonderenusernameField;
            }
            set {
                if ((object.ReferenceEquals(this.gonderenusernameField, value) != true)) {
                    this.gonderenusernameField = value;
                    this.RaisePropertyChanged("gonderenusername");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string x {
            get {
                return this.xField;
            }
            set {
                if ((object.ReferenceEquals(this.xField, value) != true)) {
                    this.xField = value;
                    this.RaisePropertyChanged("x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string y {
            get {
                return this.yField;
            }
            set {
                if ((object.ReferenceEquals(this.yField, value) != true)) {
                    this.yField = value;
                    this.RaisePropertyChanged("y");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        string login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/login", ReplyAction="http://tempuri.org/IService1/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kayitekle", ReplyAction="http://tempuri.org/IService1/kayitekleResponse")]
        int kayitekle(string username, string password, byte[] image, int age, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/kayitekle", ReplyAction="http://tempuri.org/IService1/kayitekleResponse")]
        System.Threading.Tasks.Task<int> kayitekleAsync(string username, string password, byte[] image, int age, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatle", ReplyAction="http://tempuri.org/IService1/chatleResponse")]
        int chatle(string gonderenusername, string aliciusername, string text, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatle", ReplyAction="http://tempuri.org/IService1/chatleResponse")]
        System.Threading.Tasks.Task<int> chatleAsync(string gonderenusername, string aliciusername, string text, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatgoster", ReplyAction="http://tempuri.org/IService1/chatgosterResponse")]
        string chatgoster(string gonderenusername, string aliciusername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatgoster", ReplyAction="http://tempuri.org/IService1/chatgosterResponse")]
        System.Threading.Tasks.Task<string> chatgosterAsync(string gonderenusername, string aliciusername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/konumat", ReplyAction="http://tempuri.org/IService1/konumatResponse")]
        int konumat(string gonderenusername, string aliciusername, string x, string y, string adres, string aciklama, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/konumat", ReplyAction="http://tempuri.org/IService1/konumatResponse")]
        System.Threading.Tasks.Task<int> konumatAsync(string gonderenusername, string aliciusername, string x, string y, string adres, string aciklama, System.DateTime time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/coinayarla", ReplyAction="http://tempuri.org/IService1/coinayarlaResponse")]
        int coinayarla(string username, int coin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/coinayarla", ReplyAction="http://tempuri.org/IService1/coinayarlaResponse")]
        System.Threading.Tasks.Task<int> coinayarlaAsync(string username, int coin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/coinbul", ReplyAction="http://tempuri.org/IService1/coinbulResponse")]
        int coinbul(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/coinbul", ReplyAction="http://tempuri.org/IService1/coinbulResponse")]
        System.Threading.Tasks.Task<int> coinbulAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatruletsayi", ReplyAction="http://tempuri.org/IService1/chatruletsayiResponse")]
        int chatruletsayi(int kacakadar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/chatruletsayi", ReplyAction="http://tempuri.org/IService1/chatruletsayiResponse")]
        System.Threading.Tasks.Task<int> chatruletsayiAsync(int kacakadar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userupdate", ReplyAction="http://tempuri.org/IService1/userupdateResponse")]
        int userupdate(string username, string password, int age, byte[] image, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userupdate", ReplyAction="http://tempuri.org/IService1/userupdateResponse")]
        System.Threading.Tasks.Task<int> userupdateAsync(string username, string password, int age, byte[] image, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/betplay", ReplyAction="http://tempuri.org/IService1/betplayResponse")]
        string betplay(string username, int coincount, int renk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/betplay", ReplyAction="http://tempuri.org/IService1/betplayResponse")]
        System.Threading.Tasks.Task<string> betplayAsync(string username, int coincount, int renk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/altiuserbul", ReplyAction="http://tempuri.org/IService1/altiuserbulResponse")]
        int[] altiuserbul();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/altiuserbul", ReplyAction="http://tempuri.org/IService1/altiuserbulResponse")]
        System.Threading.Tasks.Task<int[]> altiuserbulAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userbilgibul", ReplyAction="http://tempuri.org/IService1/userbilgibulResponse")]
        ClientTest.ServiceReference1.userbilgi userbilgibul(int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userbilgibul", ReplyAction="http://tempuri.org/IService1/userbilgibulResponse")]
        System.Threading.Tasks.Task<ClientTest.ServiceReference1.userbilgi> userbilgibulAsync(int userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/konumbilgigoster", ReplyAction="http://tempuri.org/IService1/konumbilgigosterResponse")]
        ClientTest.ServiceReference1.konumbilgi konumbilgigoster(string gonderenusername, string aliciusername);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/konumbilgigoster", ReplyAction="http://tempuri.org/IService1/konumbilgigosterResponse")]
        System.Threading.Tasks.Task<ClientTest.ServiceReference1.konumbilgi> konumbilgigosterAsync(string gonderenusername, string aliciusername);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientTest.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientTest.ServiceReference1.IService1>, ClientTest.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string login(string username, string password) {
            return base.Channel.login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string username, string password) {
            return base.Channel.loginAsync(username, password);
        }
        
        public int kayitekle(string username, string password, byte[] image, int age, string email) {
            return base.Channel.kayitekle(username, password, image, age, email);
        }
        
        public System.Threading.Tasks.Task<int> kayitekleAsync(string username, string password, byte[] image, int age, string email) {
            return base.Channel.kayitekleAsync(username, password, image, age, email);
        }
        
        public int chatle(string gonderenusername, string aliciusername, string text, System.DateTime time) {
            return base.Channel.chatle(gonderenusername, aliciusername, text, time);
        }
        
        public System.Threading.Tasks.Task<int> chatleAsync(string gonderenusername, string aliciusername, string text, System.DateTime time) {
            return base.Channel.chatleAsync(gonderenusername, aliciusername, text, time);
        }
        
        public string chatgoster(string gonderenusername, string aliciusername) {
            return base.Channel.chatgoster(gonderenusername, aliciusername);
        }
        
        public System.Threading.Tasks.Task<string> chatgosterAsync(string gonderenusername, string aliciusername) {
            return base.Channel.chatgosterAsync(gonderenusername, aliciusername);
        }
        
        public int konumat(string gonderenusername, string aliciusername, string x, string y, string adres, string aciklama, System.DateTime time) {
            return base.Channel.konumat(gonderenusername, aliciusername, x, y, adres, aciklama, time);
        }
        
        public System.Threading.Tasks.Task<int> konumatAsync(string gonderenusername, string aliciusername, string x, string y, string adres, string aciklama, System.DateTime time) {
            return base.Channel.konumatAsync(gonderenusername, aliciusername, x, y, adres, aciklama, time);
        }
        
        public int coinayarla(string username, int coin) {
            return base.Channel.coinayarla(username, coin);
        }
        
        public System.Threading.Tasks.Task<int> coinayarlaAsync(string username, int coin) {
            return base.Channel.coinayarlaAsync(username, coin);
        }
        
        public int coinbul(string username) {
            return base.Channel.coinbul(username);
        }
        
        public System.Threading.Tasks.Task<int> coinbulAsync(string username) {
            return base.Channel.coinbulAsync(username);
        }
        
        public int chatruletsayi(int kacakadar) {
            return base.Channel.chatruletsayi(kacakadar);
        }
        
        public System.Threading.Tasks.Task<int> chatruletsayiAsync(int kacakadar) {
            return base.Channel.chatruletsayiAsync(kacakadar);
        }
        
        public int userupdate(string username, string password, int age, byte[] image, string email) {
            return base.Channel.userupdate(username, password, age, image, email);
        }
        
        public System.Threading.Tasks.Task<int> userupdateAsync(string username, string password, int age, byte[] image, string email) {
            return base.Channel.userupdateAsync(username, password, age, image, email);
        }
        
        public string betplay(string username, int coincount, int renk) {
            return base.Channel.betplay(username, coincount, renk);
        }
        
        public System.Threading.Tasks.Task<string> betplayAsync(string username, int coincount, int renk) {
            return base.Channel.betplayAsync(username, coincount, renk);
        }
        
        public int[] altiuserbul() {
            return base.Channel.altiuserbul();
        }
        
        public System.Threading.Tasks.Task<int[]> altiuserbulAsync() {
            return base.Channel.altiuserbulAsync();
        }
        
        public ClientTest.ServiceReference1.userbilgi userbilgibul(int userid) {
            return base.Channel.userbilgibul(userid);
        }
        
        public System.Threading.Tasks.Task<ClientTest.ServiceReference1.userbilgi> userbilgibulAsync(int userid) {
            return base.Channel.userbilgibulAsync(userid);
        }
        
        public ClientTest.ServiceReference1.konumbilgi konumbilgigoster(string gonderenusername, string aliciusername) {
            return base.Channel.konumbilgigoster(gonderenusername, aliciusername);
        }
        
        public System.Threading.Tasks.Task<ClientTest.ServiceReference1.konumbilgi> konumbilgigosterAsync(string gonderenusername, string aliciusername) {
            return base.Channel.konumbilgigosterAsync(gonderenusername, aliciusername);
        }
    }
}