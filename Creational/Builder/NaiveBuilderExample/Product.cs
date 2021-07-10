using System.Collections.Generic;

namespace NaiveBuilderExample
{
    public class Product{
        private List<object> parts = new List<object>();

        public void add(string part){
            this.parts.Add(part);
        }

        public string listParts(){
            string str = string.Empty;

            foreach(string s in this.parts){
                str += s + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Product parts are: " + str + "\n";
        }
    }
}