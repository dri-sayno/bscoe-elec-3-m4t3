using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour {

	void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            print("hey");
        }
    }
}
