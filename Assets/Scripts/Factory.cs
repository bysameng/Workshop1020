using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour {

	public GameObject enemy;

	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(Random.Range(-7f, 7f), 10, 0);

		if (Input.GetKeyDown(KeyCode.Space)){
			Instantiate(enemy, transform.position, Quaternion.identity);
		}

	}
}
