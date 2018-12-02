using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haffman
{
    [Serializable]
    public class EncryptedFile
    {
        public Dictionary<byte?, ArrayList> decodeTable;
        public ArrayList encodedCode;

        public EncryptedFile() { }
        public EncryptedFile(Dictionary<byte?, ArrayList> decodeTable, ArrayList encodedCode)
        {
            this.decodeTable = new Dictionary<byte?, ArrayList>(decodeTable);
            this.encodedCode = new ArrayList(encodedCode);
            
        }


    }
}
