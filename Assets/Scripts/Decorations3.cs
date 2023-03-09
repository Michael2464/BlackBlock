using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorations3 : MonoBehaviour
{

    public GameObject m_MovingPlatform1;
    public GameObject m_MovingPlatform2;
    public GameObject m_MovingPlatform3;

    public Transform m_MPPos1_1;
    public Transform m_MPPos1_2;

    public Transform m_MPPos2_1;
    public Transform m_MPPos2_2;

    public Transform m_MPPos3_1;
    public Transform m_MPPos3_2;

    private Vector3 m_NextPos1;
    private Vector3 m_NextPos2;
    private Vector3 m_NextPos3;

    private float m_Speed = 3f;

    void Awake()
    {
        m_NextPos1 = m_MPPos1_2.position;
        m_NextPos2 = m_MPPos2_1.position;
        m_NextPos3 = m_MPPos3_2.position;
    }

    void Update()
    {
        if (m_MovingPlatform1.transform.position == m_MPPos1_1.position) {
            m_NextPos1 = m_MPPos1_2.position;
        }
        else if (m_MovingPlatform1.transform.position == m_MPPos1_2.position) {
            m_NextPos1 = m_MPPos1_1.position;
        }

        if (m_MovingPlatform2.transform.position == m_MPPos2_1.position) {
            m_NextPos2 = m_MPPos2_2.position;
        }
        else if (m_MovingPlatform2.transform.position == m_MPPos2_2.position) {
            m_NextPos2 = m_MPPos2_1.position;
        }

        if (m_MovingPlatform3.transform.position == m_MPPos3_1.position) {
            m_NextPos3 = m_MPPos3_2.position;
        }
        else if (m_MovingPlatform3.transform.position == m_MPPos3_2.position) {
            m_NextPos3 = m_MPPos3_1.position;
        }

        m_MovingPlatform1.transform.position = Vector3.MoveTowards(m_MovingPlatform1.transform.position, m_NextPos1, m_Speed * Time.deltaTime);
        m_MovingPlatform2.transform.position = Vector3.MoveTowards(m_MovingPlatform2.transform.position, m_NextPos2, m_Speed * Time.deltaTime);
        m_MovingPlatform3.transform.position = Vector3.MoveTowards(m_MovingPlatform3.transform.position, m_NextPos3, m_Speed * Time.deltaTime);
    }
}
