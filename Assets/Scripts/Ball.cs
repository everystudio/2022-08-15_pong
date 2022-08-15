using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float m_fPower;

    private Rigidbody2D m_rb;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.AddForce(new Vector2(1f, 1f).normalized * m_fPower, ForceMode2D.Impulse);
    }

}
