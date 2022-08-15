using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text m_txtScore;
    public int m_iScore;

    void Start()
    {
        m_iScore = 0;
        ShowUpdate(m_iScore);
    }

    private void ShowUpdate(int _iScore)
    {
        m_txtScore.text = _iScore.ToString();
    }

    private void OnCollisionEnter2D(Collision2D _other)
    {
        if (_other.gameObject.CompareTag("ball"))
        {
            m_iScore += 1;
            //m_iScore = m_iScore + 1;

            ShowUpdate(m_iScore);
        }
    }

}
