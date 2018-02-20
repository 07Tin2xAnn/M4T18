using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {
   

    // Use this for initialization
    void Awake() {
        DontDestroyOnLoad(gameObject);
    }
	void Start () {
        Invoke("LoadFirstScene",2f);
	}
    void LoadGame() {

        SceneManager.LoadScene(1);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
