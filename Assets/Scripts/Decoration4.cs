using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration4 : MonoBehaviour
{
    public GameObject m_MovingPlatform1;
    public GameObject m_MovingPlatform2;

    public Transform m_Pos1;
    public Transform m_Pos2;

    public Vector3 m_InitPos1;
    public Vector3 m_InitPos2;

    private float m_Speed = 0.67f;
    public bool is_Moving = false;

    private void Awake()
    {
        m_InitPos1 = m_MovingPlatform1.transform.position;
        m_InitPos2 = m_MovingPlatform2.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Player":
                {
                    is_Moving = true;
                    break;
                }
        }
    }

    void Update()
    {
        if (is_Moving)
        {
            m_MovingPlatform1.transform.position = Vector3.MoveTowards(m_MovingPlatform1.transform.position, m_Pos1.position, m_Speed * Time.deltaTime);
            m_MovingPlatform2.transform.position = Vector3.MoveTowards(m_MovingPlatform2.transform.position, m_Pos2.position, m_Speed * 3.0f * Time.deltaTime);
        }
    }


}
