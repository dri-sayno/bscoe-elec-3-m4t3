using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour {

    [SerializeField] ParticleSystem fx;
    [SerializeField] GameObject missile;
    [SerializeField] float dTime;


    void Explosion()
    {
        fx.Play();
        Destroy(gameObject, dTime);
    }

    void OnTriggerEnter(Collider missile)
    {
        //SceneManager.LoadScene(0);
        Explosion();
    }

}
