using UnityEngine;
using System.Collections;

public class IntroController : MonoBehaviour {

	public string level;

	// Use this for initialization
	void Start () {
		StartCoroutine( Order() );
	}

	IEnumerator Order() {
		yield return new WaitForSeconds (3.0f); 
		Application.LoadLevel(level);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
