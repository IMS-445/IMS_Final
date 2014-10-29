using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int civiliansSaved;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		civiliansSaved = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
