using UnityEngine;
using System.Collections;
using System.Xml;

public class Xml : MonoBehaviour {

    private string path = "Assets/XMLData/web.xml";

	void Start () {
        ReadXML(path);
	}

	/// <summary>
	/// 读XML文件
	/// </summary>
	/// <param name="path">XML文件路径</param>
    private void ReadXML(string path)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(path);
        XmlNode root = doc.SelectSingleNode("Web");
        XmlNodeList nodelist = root.ChildNodes;

        foreach(XmlNode node in nodelist)
        {
            int id = int.Parse(node.Attributes["id"].Value);
            string name = node.ChildNodes[0].InnerText;
            string url = node.ChildNodes[1].InnerText;

            Debug.Log("id=" + id + "-----name=" + name + "-------url=" + url);
        }
    }
}
