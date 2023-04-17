using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprigResetter : MonoBehaviour
{
    private SpringJoint _springJoint;
    private Rigidbody _rb;
    private float _force = 200.0f;
    void Start()
    {
        _springJoint = GetComponent<SpringJoint>();
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(ResetSpring());
    }

    void FixedUpdate()
    {
        
    }

    private IEnumerator ResetSpring() {
        while(true) {
            yield return new WaitForSeconds(2.0f);
            _rb.AddForce(transform.right * _force, ForceMode.Impulse);    
        }
    }
}
