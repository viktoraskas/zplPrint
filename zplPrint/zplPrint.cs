using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using zplPrint.helpers;
using zplPrint.models;


namespace zplPrint
{
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IzplPrint
    {
        //[DispId(0)]
        string Print(string data);
        string Test();
    }

    [ComSourceInterfaces(typeof(IzplPrint))]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("zplPrint")]
    [ComVisible(true)]
    public class zplPrint : IzplPrint
    {
        labelTemplate _labelTemplate;
        public zplPrint() 
        { 
        }

        public string Print(string data)
        {
            if(!data.IsJson())
            {
                return "Data not JSON formated.";
            }
            //Note results = JsonSerializer.Deserialize<Note>(jsonString);
            _labelTemplate = JsonSerializer.Deserialize<labelTemplate>(data);
            return "Printed";
        }

        public string Test()
        {
            return "OK";
        }
    }
}
