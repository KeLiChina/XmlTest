using UnityEngine;
using System.Collections;
using System.Xml;
using System.Collections.Generic;

public class ReadShopData : MonoBehaviour {

    private string path = "Assets/XMLData/ShopData.xml";
    private List<ShopData> shoplist= new List<ShopData>();

	void Start () {
        ReadXMLByPath(path);
        CheckXML();
	}
	

    private void ReadXMLByPath(string path)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        XmlNode root = doc.SelectSingleNode("Shop");
        XmlNodeList nodelist = root.ChildNodes;

        foreach(XmlNode node in nodelist)
        {
           string speed =  node.ChildNodes[0].InnerText;
           string rotate = node.ChildNodes[1].InnerText;
           string model = node.ChildNodes[2].InnerText;
           string price = node.ChildNodes[3].InnerText;
           ShopData shopdata = new ShopData(speed, rotate, model, price);
           shoplist.Add(shopdata);   
        }
    }

    private void CheckXML()
    {
        for (int i = 0; i < shoplist.Count; i++)
            Debug.Log(shoplist[i].ToString());
    }
}
