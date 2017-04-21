using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropObject : MonoBehaviour {

	public GameObject obj;
	public GameObject botBase;
	public GameObject botTop;
	public GameObject botCannon;
	private int n;

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "obj")
		{
			Debug.Log ("Enter!");
			Destroy (coll.gameObject);
			if (coll.gameObject.name == "bot_bot") {
				botBase.SetActive (true);
			}
			if (coll.gameObject.name == "bot_bot (1)") {
				botTop.SetActive (true);
			}
			if (coll.gameObject.name == "bot_barrel") {
				botCannon.SetActive (true);
			}
				
		}

	}


}
