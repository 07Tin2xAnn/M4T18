using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_collision : MonoBehaviour {

    public ParticleSystem exp;
    float delayTime = 1f;

    // Use this for initialization
    void Start() {
        exp.Stop();
    }

    // Update is called once per frame
    void Update() {

    }
    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.name);
    }

    void OnParticleCollision(GameObject other)
    {


        if (other.gameObject.name == "Bullet")
        {
            exp.Play();
            Invoke("DelayedAction", delayTime);
        }
    }

    void DelayedAction()
    {
        Destroy(gameObject);
    }
}
