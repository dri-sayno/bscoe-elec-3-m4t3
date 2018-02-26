using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collider : MonoBehaviour {

    [SerializeField] ParticleSystem fx;
    [SerializeField] float dTime;

    void Start()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        fx.Play();
        Invoke("NewScene", dTime);
    }

    void NewScene()
    {
        SceneManager.LoadScene(1);
    }
}
