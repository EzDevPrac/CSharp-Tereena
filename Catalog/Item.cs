using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Item
    {
        private string name;
        private string code;
        private string category;
        private int size;

        public Item()
        {

        }
        public Item(string name, string code, string category, int size)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.size = size;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetCode()
        {
            return code;
        }
        public void SetCode(string code)
        {
            this.code = code;
        }
        public string GetCategory()
        {
            return category;
        }
        public void SetCategory(string category)
        {
            this.category = category;
        }
        public int GetSize()
        {
            return size;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }
    }
}
