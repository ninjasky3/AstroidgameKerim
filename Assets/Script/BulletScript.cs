using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		rigidbody.AddRelativeForce(Vector3.back * 500);
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.collider.gameObject.name == "Astroid")
		{
				col.gameObject.SetActive(false);
		Destroy(col.gameObject);	
		}
		
		if (col.collider.gameObject.name == "Ufo")
		{
			
		Destroy(col.gameObject);	
		}
	}

}
