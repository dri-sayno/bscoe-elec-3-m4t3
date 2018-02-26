using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    [SerializeField] ParticleSystem fx;
    [SerializeField] GameObject missilee;
    [SerializeField] float dTime;


    void Explosion()
    {
        fx.Play();
        Destroy(gameObject, dTime);
    }

    void OnTriggerEnter(Collider missilee)
    {
        Explosion();
    }

}
