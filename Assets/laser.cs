using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laser : MonoBehaviour
{

    public ParticleSystem explosion;
    float delayTime = 1f;

    // Use this for initialization
    void Start()
    {
        explosion.Stop();
    }

    void DelayedAction()
    {
		Destroy(gameObject);
		SceneManager.LoadScene (1);
    }

	void OnCollisionEnter(Collision col){
		explosion.Play();
		Invoke("DelayedAction", delayTime);
	}
}