using UnityEngine;
using System.Collections;

public class planterTypeA : MonoBehaviour {

	public Transform egg;
	public Transform planter;
	float plantTime = 0f;

	// Use this for initialization
	void Start () {
		plantTime = Time.time + 3f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (plantTime);
		if (Time.time > plantTime){
			Debug.Log ("Something should happen by now?");
			if(Random.Range(0f, 1f) > 0.15f){ //spawn an egg 85% of the time
				Instantiate (egg, transform.position, Quaternion.identity);
				Debug.Log("Instantiate Egg");
			}
			else{ //spawn a chicken 15% of the time
				Instantiate (planter, transform.position - transform.forward, Quaternion.identity);
				Debug.Log ("Instantiate Chicken");
			}
			plantTime += Random.Range (3f, 12f);
		}
	}
}
