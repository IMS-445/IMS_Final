using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
    public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        print("Triggered collision");
        Application.LoadLevel(levelName);
    }


}
