using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoretext;
    public static int score = 0;


    void Update () {
        scoretext.text = "Score:" +  score.ToString();
	}  
}
