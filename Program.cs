using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial sampleTutorial = new Tutorial();

            sampleTutorial.id = 1;
            sampleTutorial.name = ".Net Tutorial";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\your\\file\\path\\ishere\\result.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, sampleTutorial);
            stream.Close();

            stream = new FileStream("C:\\your\\file\\path\\ishere\\result.txt", FileMode.Open, FileAccess.Read);
            
            Tutorial deserializeInfo = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine("Deserializing of the result.txt file ");
            Console.WriteLine("ID: " + deserializeInfo.id);
            Console.WriteLine("Name: " + deserializeInfo.name);

            Console.ReadKey();

        }
    }
}
