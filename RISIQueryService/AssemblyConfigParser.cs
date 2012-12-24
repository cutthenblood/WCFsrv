using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RISIQueryService
{
    public class ClientsInfo
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string TypeName { get; set; }
        public string AssemblyName { get; set; }
        public Dictionary<string, string> EndpoinURIs { get; set; }
       // public void Add(string name,string id,string typename,string assemblyname,
    }



    public class AssemblyConfigParser
    {
        public static Dictionary<string,string> EndpointURI(string path,string assemblyname,string typename)
        {
            if (!File.Exists(path+"\\"+assemblyname + ".config"))
                return null;
            Dictionary<string, string> endpointURIs =new Dictionary<string, string>();
            List<ClientsInfo> clientInfo=new List<ClientsInfo>();

            XDocument doc = XDocument.Load(path + "\\" + assemblyname + ".config");
            foreach (XElement el in doc.Root.Elements())
            {
                if (el.Name == assemblyname)
                    foreach(var assemblySection in el.Elements())
                        if(assemblySection.Name==typename)
                            foreach(XElement clientSection in assemblySection.Elements())
                                if (clientSection.Name == "Clinet")
                                {
                                    foreach(XAttribute attr in clientSection.Attributes())
                                    if(attr.Name=="name"
                                }
                            
                        //    foreach (XElement typeSection in assemblySection.Elements())
                        //        {
                        //if(typeSection.Name=="endpointURI")
                        //    foreach (XAttribute attr in typeSection.Attributes())
                        //    {
                        //        if(attr.Name=="bindingName")
                        //            endpointURIs.Add(attr.Value,typeSection.Value);
                        //    }
                        //        }

            }
            return endpointURIs;


        }
        //public System.ServiceModel.Security.UserNamePasswordClientCredential Credentials
    }
}
