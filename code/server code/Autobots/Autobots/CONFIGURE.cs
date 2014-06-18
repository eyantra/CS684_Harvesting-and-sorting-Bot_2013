using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
u
namespace Autobots
{
    class CONFIGURE
    {
        XmlDocument xdco;
        string pathname;
        public CONFIGURE(string save)
        {
            xdco = new XmlDocument();
            xdco.Load(save);
            pathname = save;
        }
        //public addnew(config confg)
        //{
        //        XmlAttribute LH=new XmlAttribute();;
        //        XmlNode newSettinng=xdco.CreateNode(XmlNodeType.Element,"setting",null);
        //        XmlAttribute LH=xdco.crea
        //}
        public void AddCONGIGDetail(int PanalIndex)
        {
            xDocument.Load(pathname);
            XmlNode newfile = xDocument.CreateNode(XmlNodeType.Element, "config", null);
            XmlAttribute xIsFile = xDocument.CreateAttribute("isFile");
            xIsFile.Value = details.isFile.ToString();
            XmlAttribute xpath = xDocument.CreateAttribute("Path");
            xpath.Value = details.Path;
            XmlAttribute ximage = xDocument.CreateAttribute("Image");
            ximage.Value = details.Image;
            XmlAttribute Count = xDocument.CreateAttribute("Count");
            Count.Value = "1";
            newfile.Attributes.Append(xIsFile);
            newfile.Attributes.Append(xpath);
            newfile.Attributes.Append(ximage);
            newfile.Attributes.Append(Count);
            xDocument.SelectSingleNode("Autobots").SelectSingleNode("holder[@ID='" + PanalIndex.ToString() + "']").AppendChild(newfile);
            SaveDB();
            IsOld = false;
        }

    }
}
