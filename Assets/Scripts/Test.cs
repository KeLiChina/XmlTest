using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    private GameObject New_GO;
    private float[] airWallSize;
    void Start()
    {   
       
        New_GO = new GameObject();
        CreatANewGO();
    }

	
	private void CreatANewGO()
    {
      GameObject Ins_NewGO =  Instantiate(New_GO, gameObject.GetComponent<Transform>().position, Quaternion.identity, gameObject.transform) as GameObject;
      Ins_NewGO.name = "AirWall";
      Debug.Log("++++++++++++<" + Ins_NewGO.name + ">++++++++++");
      BoxCollider AirWall = Ins_NewGO.AddComponent<BoxCollider>();
      AirWall.size = (new Vector3(50f, 1f, 50f));
    }


}
