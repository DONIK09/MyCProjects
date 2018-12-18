using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpisokInterface
{
    class MyContainer
    {
        private List<Element> ElementList;
        private ListBox listBox;

        public MyContainer(ListBox listBox)
        {
            this.ElementList = new List<Element>();
            this.listBox = listBox;
        }

        public void EchoElementList() //Печать всего списка
        {
            listBox.Items.Clear();
            if (ElementList.Count != 0) ElementList.ForEach(value => { this.listBox.Items.Add(value); });
        }
        public void ClearAll() { this.ElementList.Clear();this.listBox.Items.Clear(); } //Полная очистка
        public void AddElement(string Data) //Добавление элемента
        {
            double i;
            if (double.TryParse(Data, out i)) { this.ElementList.Add(new MyNumber(i));}
            else { this.ElementList.Add(new MyString(Data)); };
            this.EchoElementList();
        }
        public void RemoveElement( )//Удаление элемента
        {
            this.ElementList.Remove((Element)this.listBox.SelectedItem);
            this.EchoElementList();
        }
        public void Find(string Data) //Поиск элемента
        {
            bool isFind = false;
            double i;
            if (double.TryParse(Data, out i)) { this.ElementList.ForEach(value => { if (value is MyNumber) if ((double)value.getData() == i) { this.listBox.SelectedItem = value;isFind = true; } });}
            else { this.ElementList.ForEach(value => { if (value is MyString) if (value.getData().Equals(Data)) { this.listBox.SelectedItem = value;isFind = true; } });};
            if (!isFind)
            {
                this.listBox.SelectedItem = null;
                MessageBox.Show("Элемент " + Data + " не найден!");
            }
        }
        public void changeElement(string Data)//Изменение данных
        {
            ((Element)this.listBox.SelectedItem).changeData(Data);
            this.EchoElementList();
        }
        public void sortElements()
        {
            this.ElementList.Sort();
            this.EchoElementList();
        }
    }
}
