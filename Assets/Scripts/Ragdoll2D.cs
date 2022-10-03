using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class Ragdoll2D : MonoBehaviour
{
    public bool _currentRagdoll = false;

    private void Start()
    {
        OnValidate();
    }

    private void OnValidate()
    {
        ToggleRagdoll(_currentRagdoll);
    }
    public void ToggleRagdoll(bool ragdollOn)
    {
        GetComponent<Animator>().enabled = !ragdollOn;
        GetComponent<IKManager2D>().enabled = !ragdollOn;

        foreach (var col in GetComponentsInChildren<CapsuleCollider2D>())
        {
            col.enabled = ragdollOn;
        }

        foreach (var joint in GetComponentsInChildren<HingeJoint2D>())
        {
            joint.enabled = ragdollOn;
        }

        foreach (var rb in GetComponentsInChildren<Rigidbody2D>())
        {
            rb.simulated = ragdollOn;
        }

    }
}
