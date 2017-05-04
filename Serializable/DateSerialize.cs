//============================================================================
//                                                                            
//           Author:  Pengbo-Hu
//      Last Change:  5-4-2017   
//          License:  MIT
//           GitHub:  Taaccoo-beta 
//             Mail:  Taaccoo2.0@outlook.com  
//
//============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace DataSave
{
    //[Serializable]
    //class DataPara
    //{
    //    public String Date;
    //    public String index;
    //}

    [Serializable]
    class DataFater
    {

    }


    class CoreDateSerialize
    {

        private string Path_data;
        private DataFater data;
       
        public CoreDateSerialize(string fileNmae,DataFater o)
        {
           
            this.Path_data= @fileNmae;
            this.data = o;
              
           
        }

        public void DateSerializeNow()
        {
            FileStream fileStream = new FileStream(Path_data, FileMode.OpenOrCreate);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, data);
            fileStream.Close();
        }

        public DataFater DateDeSerializeNow()
        {
            
            FileStream fileStream = new FileStream(Path_data, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter b = new BinaryFormatter();
            data = b.Deserialize(fileStream) as DataFater;
            fileStream.Close();

            return data;
        }

      

    }
}
