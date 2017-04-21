using UnityEngine;
using System.Collections;

public class pickUpObject : MonoBehaviour {
	public GameObject obj;
	public GameObject obj2;
	public GameObject drpp;
	private int n;

	void OnTriggerEnter(Collider coll)
	{
		if(coll.tag == "obj")
		{
			Debug.Log ("Enter!");
			coll.transform.parent = transform;
			coll.transform.localScale = new Vector3 (200, 11, 200);
			coll.transform.rotation = transform.parent.rotation;
			n = 1;
		}

		Debug.Log (coll.tag);
		if(coll.tag == "drpp")
		{
			Debug.Log ("Aangeraakt!");
//			obj.transform.parent = coll.transform;
//			obj.transform.localScale = new Vector3 (14, 141, 20);
//			obj2.transform.parent = coll.transform;
//			obj2.transform.localScale = new Vector3 (14, 141, 20);
			n = 2;
			StopCoroutine ("OnTriggerEnter");
		}
	}
		

	void Update()
	{
		if (n == 1)
		{
			Vector3 pos = obj.transform.position;
			pos = Vector3.Lerp(obj.transform.position, transform.position, Time.deltaTime * 30);
			obj.transform.position = pos;
			obj.transform.rotation = transform.rotation;
		}
		if (n == 2)
		{
			Vector3 pos = obj.transform.position;
			pos = Vector3.Lerp(obj.transform.position, drpp.transform.position, Time.deltaTime * 30);
			obj.transform.position = pos;
			obj.transform.rotation = drpp.transform.rotation;
		}
	}
}
