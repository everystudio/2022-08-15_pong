using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_fSpeed;

    [SerializeField] private string AxisName;

    private void Update()
    {
        transform.Translate(
            0f,
            Input.GetAxisRaw(AxisName) * m_fSpeed * Time.deltaTime,
            0f);
    }
}
