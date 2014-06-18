using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

    namespace Autobots
    {
        class configHandle
        {
            XmlDocument xDocument;
            string pathname;
            public configHandle(string save)
            {
                xDocument = new XmlDocument();
                xDocument.Load(save);
                pathname = save;
            }
            //public addnew(config confg)
            //{
            //        XmlAttribute LH=new XmlAttribute();;
            //        XmlNode newSettinng=xdco.CreateNode(XmlNodeType.Element,"setting",null);
            //        XmlAttribute LH=xdco.crea
            //}

            public List<string> getallCOnfigName()
            {
                List<string> allconfig = new List<string>();
                 System.Xml.XPath.XPathNavigator xnavi=xDocument.CreateNavigator();
                 System.Xml.XPath.XPathExpression exp = xnavi.Compile("Autobots//*");
                 System.Xml.XPath.XPathNodeIterator list = xnavi.Select(exp);
                 while (list.MoveNext())
                 {
                    allconfig.Add(list.Current.GetAttribute("name",""));
                 
                 }
               //  System.Windows.Forms.MessageBox.Show(allconfig.Count.ToString());
                return allconfig;

            
            }
            public configuration GetCOnfig(string ConfName)
            {

                System.Xml.XPath.XPathNavigator xnavi = xDocument.CreateNavigator();
                System.Xml.XPath.XPathExpression exp = xnavi.Compile("Autobots//config[@name='"+ConfName+"']");
                System.Xml.XPath.XPathNodeIterator list = xnavi.Select(exp);
              
                configuration confifound= new configuration();
                list.MoveNext();
                 confifound.name=  list.Current.GetAttribute("name", "").ToString();
                 confifound.HV = int.Parse(list.Current.GetAttribute("HV", "").ToString());
                 confifound.HH = int.Parse(list.Current.GetAttribute("HH", "").ToString());
                 confifound.HS = int.Parse(list.Current.GetAttribute("HS", "").ToString());

                 confifound.LH = int.Parse(list.Current.GetAttribute("LH", "").ToString());
                 confifound.LS = int.Parse(list.Current.GetAttribute("LS", "").ToString());
                 confifound.LV = int.Parse(list.Current.GetAttribute("LV", "").ToString());

                 confifound.MNM = int.Parse(list.Current.GetAttribute("MNM", "").ToString());
                 confifound.WD = int.Parse(list.Current.GetAttribute("WD", "").ToString());
                 confifound.WU = int.Parse(list.Current.GetAttribute("WU", "").ToString());
                 confifound.WR = int.Parse(list.Current.GetAttribute("WR", "").ToString());
                 confifound.WL = int.Parse(list.Current.GetAttribute("WL", "").ToString());

                confifound.TS = int.Parse(list.Current.GetAttribute("TS", "").ToString());
                    confifound.TL = int.Parse(list.Current.GetAttribute("TL", "").ToString());
                    confifound.Dlt = int.Parse(list.Current.GetAttribute("Dil", "").ToString());
                    confifound.erd = int.Parse(list.Current.GetAttribute("Erd", "").ToString());
                    return confifound;
            }
            public void AddCONGIGDetail(configuration details)
            {
                xDocument.Load(pathname);
                XmlNode newfile = xDocument.CreateNode(XmlNodeType.Element, "config", null);
                XmlAttribute namecn = xDocument.CreateAttribute("name");
                namecn.Value = details.name.ToString();
                XmlAttribute LS = xDocument.CreateAttribute("LS");
                LS.Value = details.LS.ToString();
                XmlAttribute LH = xDocument.CreateAttribute("LH");
                LH.Value = details.LH.ToString();
                XmlAttribute LV = xDocument.CreateAttribute("LV");
                LV.Value = details.LV.ToString();
             
                XmlAttribute HS = xDocument.CreateAttribute("HS");
                HS.Value = details.HS.ToString();
                XmlAttribute HH = xDocument.CreateAttribute("HH");
                HH.Value = details.HH.ToString();
                XmlAttribute HV = xDocument.CreateAttribute("HV");
                HV.Value = details.HV.ToString();

                XmlAttribute WU = xDocument.CreateAttribute("WU");
                WU.Value = details.WU.ToString();
                XmlAttribute WD = xDocument.CreateAttribute("WD");
                WD.Value = details.WD.ToString();
                XmlAttribute WL = xDocument.CreateAttribute("WL");
                WL.Value = details.WL.ToString();
                XmlAttribute WR = xDocument.CreateAttribute("WR");
                WR.Value = details.WR.ToString();

                XmlAttribute TS = xDocument.CreateAttribute("TS");
                TS.Value = details.TS.ToString(); 
                XmlAttribute TL = xDocument.CreateAttribute("TL");
                TL.Value = details.TL.ToString();

                XmlAttribute MNM = xDocument.CreateAttribute("MNM");
                MNM.Value = details.MNM.ToString(); 
                XmlAttribute Dil = xDocument.CreateAttribute("Dil");
                Dil.Value = details.Dlt.ToString();
                XmlAttribute Erd = xDocument.CreateAttribute("Erd");
                Erd.Value = details.erd.ToString();
                newfile.Attributes.Append(namecn);
                newfile.Attributes.Append(LH);
                newfile.Attributes.Append(LS);
                newfile.Attributes.Append(LV);

                newfile.Attributes.Append(HH);
                newfile.Attributes.Append(HS);
                newfile.Attributes.Append(HV);

                newfile.Attributes.Append(WL);
                newfile.Attributes.Append(WR);
                newfile.Attributes.Append(WU);
                newfile.Attributes.Append(WD);

                newfile.Attributes.Append(TS);
                newfile.Attributes.Append(TL);

                newfile.Attributes.Append(MNM);
                newfile.Attributes.Append(Dil);
                newfile.Attributes.Append(Erd);
                xDocument.SelectSingleNode("Autobots").AppendChild(newfile);
                xDocument.Save(pathname);
            
            }

        }
    }


