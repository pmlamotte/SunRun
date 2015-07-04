using UnityEngine;
using System.Collections;

public class HealthComponent : MonoBehaviour {

	public float health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void addHealth(float amt) {
		this.health += amt;
	}

	public void removeHealth(float amt) {
		this.health -= amt;
	}
}
