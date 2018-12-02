using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Haffman
{
    class HaffmanTree
    {
        public List<byte> imageByteArray { get; }
        public List<Node> listNode { get; set; }
        public ArrayList code { get; set; }
        public Dictionary<byte?, ArrayList > table { get; set; }
        private Node rootNode;
        private ArrayList encryptCode;
        private EncryptedFile encryptedFile;

        public HaffmanTree(byte[] imageByteArray)
        {
            listNode = new List<Node>();
            code = new ArrayList();
            encryptCode = new ArrayList();
            this.imageByteArray = imageByteArray.OfType<byte>().ToList();
            table = new Dictionary<byte?, ArrayList>();
            createNods();
            createTree();
            BuildTable(rootNode);
            this.encrypt();
            serializeAndSave();
        }
        public HaffmanTree() { }

        private void createTree()
        {
            while(listNode.Count != 1)
            {
                listNode.Sort(delegate (Node n1, Node n2) { return n1.weight.CompareTo(n2.weight); });
                Node left = listNode.First();
                listNode.Remove(left);
                Node right = listNode.First();
                listNode.Remove(right);
                Node parent = new Node(left, right);
                listNode.Add(parent);
            }
            rootNode = listNode.First();
        }

        private void BuildTable(Node root)
        {
            if (root.left != null)
            {
                code.Add(0);
                BuildTable(root.left);
            };
            if (root.right != null)
            {
                code.Add(1);
                BuildTable(root.right);
            }
             if(root.data != null)
            {
                table.Add(root.data, new ArrayList(code));
            }
            if (code.Count != 0)
            {
                code.RemoveAt(code.Count-1);
            }
        }
        private void createNods()
        {
            List<byte> removingList = new List<byte>(this.imageByteArray);
            while (removingList.Count != 0)
            {
                Node node = new Node(removingList.First());
                listNode.Add(node);
                foreach(byte item in removingList)
                {
                    if (item == node.data) node.weight++;
                }
                removingList.RemoveAll(item => item==node.data);
            }
        }
        private void encrypt()
        {
            foreach(byte item in imageByteArray)
            {
                this.encryptCode.Add(new ArrayList(this.table[item]));
            }
            this.encryptedFile = new EncryptedFile(this.table, this.encryptCode);
        }
        private void serializeAndSave()
        {
            BinaryFormatter Serializer = new BinaryFormatter();
            using (FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\image.dat", FileMode.OpenOrCreate))
            {
                Serializer.Serialize(fs, this.encryptedFile);
                            }
        }
        public ArrayList decrypt(EncryptedFile encrypted)
        {
            ArrayList decrypt = new ArrayList();
            foreach(ArrayList item in encrypted.encodedCode)
            {
                foreach(KeyValuePair<byte?,ArrayList> item1 in encrypted.decodeTable)
                {
                    if (item.ToArray().SequenceEqual(item1.Value.ToArray())) decrypt.Add(item1.Key);
                }
            }
            return decrypt;
        }
        public EncryptedFile deserialize(string Path)
        {
            BinaryFormatter Serializer = new BinaryFormatter();
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                EncryptedFile encrypted = (EncryptedFile)Serializer.Deserialize(fs);
                return encrypted;
            }
        }
    }
}
