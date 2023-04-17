using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    private HingeJoint _joint;
    void Start()
    {
        _joint = GetComponent<HingeJoint>();
        StartCoroutine(Restart());
    }

    private IEnumerator Restart() {
        while(true) {
            yield return new WaitForSeconds(2.0f);
            _joint.useMotor = !_joint.useMotor;
        }


    }
}
