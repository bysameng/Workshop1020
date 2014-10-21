using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(0, -5f, 0) * Time.deltaTime;

	}
}
