﻿using Question.Test.Interface;
using System.Reflection;
using System.Xml.Linq;

namespace Question.Test.Implementation
{
    public class ReadXml : IReadXml
    {
        /// <summary>
        /// This function needs to read an XML from the current directory.
        /// For the purpose of this implementation only worry about reading input.xml from the Xml directory.
        /// Feel from to change this implmentation how ever you wish but ensure this is reflected in the interface.
        /// </summary>
        /// <param name="xmlName">The name of the XML.</param>
        /// <returns>The XML XDocument.</returns>
        public XDocument GetXml(string xmlName)
        {
            string path = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Xml\{xmlName}.xml";
            return XDocument.Load(path);
        }
    }
}