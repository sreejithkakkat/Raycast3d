using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    [SerializeField] ParticleSystem gunHitBlack;
    [SerializeField] LayerMask layerMask;
    bool fireOnce;

    RaycastHit hitinfo;

    void Update () {

        Ray ray = new Ray (transform.position, transform.TransformDirection (Vector3.forward));

        if (Physics.Raycast (ray, out hitinfo, 20f, layerMask, QueryTriggerInteraction.Ignore)) {
            // if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out RaycastHit hitinfo, 20f, layerMask, QueryTriggerInteraction.Ignore)) {
            Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.red);

            if (Input.GetMouseButtonDown (0)) {

                gunHitBlack.transform.position = hitinfo.point;
                fireOnce = true;
                FireBullet ();

            }

        } else {
            Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * 20f, Color.green);
        }
    }

    void FireBullet () {

        if (fireOnce) {

            gunHitBlack.Play ();
            fireOnce = false;
        }

    }
}