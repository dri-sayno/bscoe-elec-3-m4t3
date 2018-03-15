using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCollision_tank2 : MonoBehaviour
{

    [SerializeField] ParticleSystem fx;
    [SerializeField] GameObject missile;
    [SerializeField] float dTime;
    public int hitpoints = 1;
    public Image healthbar;
    public AudioSource explode;

    void Explosion()
    {
        if (hitpoints == 0)
        {
            fx.Play();
            explode.Play();
            Destroy(gameObject, dTime);
            Score.score++;
        }
    }

    void OnTriggerEnter(Collider missile)
    {
        healthbar.fillAmount = healthbar.fillAmount - 0.25f;
        hitpoints--;
        Explosion();
    }

}
