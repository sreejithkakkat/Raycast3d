using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    [SerializeField] LayerMask layerMask;
    // Update is called once per frame
    void Update () {

        if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out RaycastHit hitinfo, 20f, layerMask)) {
            Debug.Log ("Hit something");
            Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.red);

        } else {
            Debug.Log ("Hit Nothing");
            Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * 20f, Color.green);
        }

    }
}