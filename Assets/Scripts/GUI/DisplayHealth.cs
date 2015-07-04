using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Text text = GetComponent<Text> ();
		text.text = "Health: " + GameObject.FindGameObjectWithTag("Player").GetComponent<HealthComponent>().health;
	}
}
