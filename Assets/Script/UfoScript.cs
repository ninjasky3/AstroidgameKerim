using UnityEngine;
using System.Collections;

public class UfoScript : MonoBehaviour {

	 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(1500.0F,0,Random.Range(0.0F, 300.0F));
		
			if(transform.position.x > 45){
	transform.position =new Vector3(-45, 0, Random.Range(-27.0F, 10.0F));	
		}
		
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.collider.gameObject.name == "Bullet")
		{

		Destroy(col.gameObject);	
		}
				
	}
	
	
}
