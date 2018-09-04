using System.Collections;

using System.Collections.Generic;

using UnityEngine;





public class SportCar_1_Controller_auto : MonoBehaviour {

	public GameObject Marker;
	
	private float timePassed;
	// Use this for initialization
	public float carSpeed = 5f;
	public Vector3[] waypoints;
	public Quaternion[] rotatestates;
	private Vector3 currPosition;
	private Quaternion currRotation;
	private int waypointIndex = 0;
	 public Transform target;

	void Start () 	{
		waypoints = new Vector3[8];
		
		waypoints.SetValue(new Vector3 (694, 52, 1383), 0);
		waypoints.SetValue(new Vector3 (799, 52, 1312), 1);
		waypoints.SetValue(new Vector3 (779, 52, 1168), 2);
		waypoints.SetValue(new Vector3 (628, 52, 944), 3);
		waypoints.SetValue(new Vector3 (685, 52, 816), 4);
		waypoints.SetValue(new Vector3 (809, 52, 690), 5);
		waypoints.SetValue(new Vector3 (817, 52, 552), 6);
		waypoints.SetValue(new Vector3 (18, 1, 0), 7);
				
		rotatestates = new Quaternion[8];

		rotatestates.SetValue(new Quaternion (-1.678f, 81.14301f, -2.395f, 0f), 0);
		rotatestates.SetValue(new Quaternion (0.934f, 199.647f, -4.122f, 0f), 1);
		//rotatestates.SetValue(new Quaternion (18, 1, 0), 2);
		//rotatestates.SetValue(new Quaternion (18, 1, 0), 3);
		//rotatestates.SetValue(new Quaternion (18, 1, 0), 4);
		//rotatestates.SetValue(new Quaternion (18, 1, 0), 5);
		//rotatestates.SetValue(new Quaternion (18, 1, 0), 6);
	}	// Update is called once per frame

		

		
	

	void Update()
	{			
		currPosition = transform.position;
		currRotation = transform.rotation;

		if (waypointIndex < waypoints.Length){
			transform.position = Vector3.MoveTowards (currPosition, waypoints[waypointIndex], carSpeed);
			Vector3 relativePos = waypoints[waypointIndex] - transform.position;
			transform.rotation = Quaternion.LookRotation(relativePos);

			//Vector3 newDir = Vector3.RotateTowards(transform.forward, waypoints[waypointIndex], carSpeed, 0.0F);
			//transform.rotation = Quaternion.LookRotation(newDir);


			if(Vector3.Distance(waypoints[waypointIndex] , currPosition) == 0f)
				waypointIndex++;
		}
	}
}