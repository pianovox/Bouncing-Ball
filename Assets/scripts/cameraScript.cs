using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {
	
	public GameObject Sphere;
	private Vector3 offset;
	
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
		transform.position = Sphere.transform.position + offset;
	}
}