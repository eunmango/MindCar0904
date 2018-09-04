using System.Collections; using System.Collections.Generic; using UnityEngine;    public class SportCar_1_Controller_com : MonoBehaviour {
 	public GameObject Marker1; 	private float timePassed;
	// Use this for initialization
 	void Start () { 		  	} 	 	// Update is called once per frame 	  		  		void Update(){  			 			if (Input.GetKey(KeyCode.UpArrow)) 				transform.Translate(new Vector3(0, 0, 2));  			if (Input.GetKey(KeyCode.DownArrow)) 				transform.Translate(new Vector3(0, 0, -2));


		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 			timePassed = Time.time;


		if (Input.GetKey(KeyCode.RightArrow) && (Time.time - timePassed) < 0.7f) 				transform.Rotate(new Vector3(0, 2, 0)); 			if (Input.GetKey(KeyCode.LeftArrow) && (Time.time - timePassed) < 0.7f) 				transform.Rotate(new Vector3(0, -2, 0));  		Marker1.transform.position = new Vector3(this.transform.position.x, -1290, this.transform.position.z); 		 			  	} }  
