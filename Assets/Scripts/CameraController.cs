using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject toFollow;

	private Vector3 velocity;
	private float smoothTime = .3f;


	// Update is called once per frame
	void Update () {
		Vector3 target = toFollow.transform.position + new Vector3(0, 2, -10);
		transform.position = Vector3.SmoothDamp(transform.position, target,
		                                        ref velocity, smoothTime);
	}
}
