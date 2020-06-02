using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ObjectEstruture
    {
        private List<Element> elements = new List<Element>();

        public void Anexar(Element element)
        {
            elements.Add(element);
        }
        public void Desanexar(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
