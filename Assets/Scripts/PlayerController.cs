using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		Debug.Log("so, i don't know what ot write here");
	}

	// Update is called once per frame
	void Update () {
//		transform.position;
//		transform.localScale;
//		transform.rotation;
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.position = transform.position + new Vector3(speed, 0, 0) * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			transform.position = transform.position - new Vector3(speed, 0, 0) * Time.deltaTime;
		}
	}

	//for collisions
	void OnTriggerEnter(Collider other){
		Destroy(gameObject);
	}

}
