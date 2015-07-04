using UnityEngine;
using System.Collections;

public class DamageOnSightComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		Vector3 objDirection = transform.TransformDirection(Vector3.back);

		bool collided = Physics.Raycast(player.transform.position, objDirection, Mathf.Infinity, ~(1 << 8));
		if (!collided) {
			HealthComponent health = player.GetComponent<HealthComponent>();
			health.removeHealth(Time.deltaTime * 1);
		}
	}
}
