using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collider : MonoBehaviour {

    void Start()
    {
        print("yo");
    }

    void OnTriggerEnter(Collider other) {
        print("JOLS");
    }
}
