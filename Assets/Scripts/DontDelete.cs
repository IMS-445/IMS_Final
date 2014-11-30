using UnityEngine;
using System.Collections;

public class DontDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
        foreach (var taggedGameObject in GameObject.FindGameObjectsWithTag("KeepMe"))
        {
            if (taggedGameObject.name == gameObject.name && taggedGameObject != gameObject)
            {
                print("Removing duplicate");
                GameObject.Destroy(gameObject);

            }
        }
        Application.DontDestroyOnLoad(gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
