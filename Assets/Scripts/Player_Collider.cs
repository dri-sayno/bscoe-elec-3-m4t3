using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Collider : MonoBehaviour
{

    [SerializeField] ParticleSystem fx;
    [SerializeField] float dTime;
    public float hitpoints;
    public Image healthbar;
    public AudioSource explode;

    void Start()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);
        healthbar.fillAmount = healthbar.fillAmount - 0.10f;
        hitpoints--;
        Explosion();
    }

    void Explosion()
    {
        Debug.Log(hitpoints);
        if (hitpoints <= 1)
        {
            fx.Play();
            explode.Play();
            Invoke("NewScene", dTime);
        }
    }

    void NewScene()
    {
        SceneManager.LoadScene(1);
        Score.score = 0;
    }
}
