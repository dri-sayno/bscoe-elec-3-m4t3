using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyCollision_plane : MonoBehaviour {

    [SerializeField] ParticleSystem fx;
    [SerializeField] GameObject missile;
    [SerializeField] float dTime;
    public float hitpoints = 2f;
    public Image healthbar;
    public AudioSource explode;

    void Explosion()
    {
        if (hitpoints == 0)
        {
            fx.Play();
            if (gameObject.activeSelf)
            {
                explode.Play();
            }
            Destroy(gameObject, dTime);
            Score.score = Score.score + 2;
        }
    }

    void OnTriggerEnter(Collider missile)
    {
        healthbar.fillAmount = healthbar.fillAmount - 0.50f;
        hitpoints--;
        Explosion();
    }
}
