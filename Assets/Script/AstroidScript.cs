using UnityEngine;
using System.Collections;

public class AstroidScript : MonoBehaviour {
	public bool playerisdead;
	public bool astroidboom;
	public static int AllAstroids;
	private int count;
	// Use this for initialization
	void Start () {
		//GameObject[] Astroids = GameObject.FindGameObjectsWithTag("Enemys");
		
		AllAstroids = 9;
	
	}
	
	// Update is called once per frame
	void Update () {
			
		if (AllAstroids == 0){
		Application.LoadLevel ("WinScreen");	
		}
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(Random.Range(-0.0F, 300.0F),0,Random.Range(0.0F, 300.0F));
		
			if(transform.position.x > 45){
	transform.position =new Vector3(Random.Range(-45.0F, -30.0F), 0, 0);	
		}
		
		if(transform.position.x < -45){
	transform.position =new Vector3(Random.Range(45.0F, -30.0F), 0, 0);	
		}
		
		if(transform.position.z > 27){
	transform.position =new Vector3(0, 0, Random.Range(28.0F, -30.0F));	
		}
		
		if(transform.position.z < -28){
	transform.position =new Vector3(0, 0, Random.Range(28.0F, -30.0F));	
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.collider.gameObject.name == "Bullet")
		{
			Instantiate(Resources.Load("Explosion"), transform.position, transform.rotation);
			AllAstroids --;
			Debug.Log(AllAstroids);
		astroidboom = true;
		Destroy(col.gameObject);	
		}
				
	}
	
	
}
