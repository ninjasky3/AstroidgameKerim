using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed;
	public float timer;
	public GUIText livesdisplay;
	public bool playerisdead;
	public int lives;
	
	// Use this for initialization
	void Start () {
		//transform.Rotate (Vector3);
		speed = 500;
	  timer = 0;
		playerisdead = false;
		lives = 5;
	}
	
	// Update is called once per frame

	void Update () {
		if (playerisdead == true){
		  //	GameObject player = Instantiate(Resources.Load("Player"),new Vector3(0,0,0), transform.rotation) as GameObject;
			//player.name = "Player";
			playerisdead = false;
		}
		if (lives == 0)
		{
			Application.LoadLevel ("LoseScreen");
		}
		timer -= Time.deltaTime;
		SetLiveText();
		//movements
	float horizontalMovement = Input.GetAxis ("Horizontal");
	float verticalMovement = Input.GetAxis("Vertical");
	Vector3 movement = new Vector3(horizontalMovement, 0.0f,-verticalMovement );
	rigidbody.AddForce(movement * speed * Time.deltaTime);
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject bullet = Instantiate(Resources.Load("Bullet"), transform.position, transform.rotation) as GameObject;
			bullet.name = "Bullet";
			
		}
		
		
		//blijf in de map
	if	(Input.GetKey(KeyCode.J)){
		transform.Rotate(new Vector3(0, 10, 0)); 
		}
	if	(Input.GetKey(KeyCode.K)){
		transform.Rotate(new Vector3(0, -10 ,0 )); 
		}
		
		if(transform.position.x > 45){
	transform.position =new Vector3(-45,0,0);	
		}
		
		if(transform.position.x < -45){
	transform.position =new Vector3(45,0,0);	
		}
		
		if(transform.position.z > 27){
	transform.position =new Vector3(0,0,-25);	
		}
		
		if(transform.position.z < -28){
	transform.position =new Vector3(0,0,25);	
		}
 }
	void OnTriggerEnter(Collider col)
	{
		
			if (col.collider.gameObject.name == "Astroid" )
		{
			playerisdead = true;
			lives -= 1;
		
		Destroy(col.gameObject);	
		}
		
		if (col.collider.gameObject.name == "Ufo" )
		{
			playerisdead = true;
			lives += 1;
		
		Destroy(col.gameObject);	
		}
	}
	void SetLiveText() {
	 	livesdisplay.text = "lives " + lives;
		
	}
}