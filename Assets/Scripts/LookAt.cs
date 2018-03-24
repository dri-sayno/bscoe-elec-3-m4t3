using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform target;
    public float degreesPerSecond;
	
	// Update is called once per frame
	void Update () {
        Vector3 dirFromMeToTarget = target.position - transform.position;
        dirFromMeToTarget.z = 0.0f;
        Quaternion lookRotation = Quaternion.LookRotation(dirFromMeToTarget);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, Time.deltaTime * (degreesPerSecond / 360.0f));
	}
}
