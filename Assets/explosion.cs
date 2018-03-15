using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public ParticleSystem explode;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator OnParticleCollision(GameObject other)
    {

        Debug.Log("Particle Hit");
        explode.Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);

    }
}