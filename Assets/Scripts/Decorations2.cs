using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorations2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject m_MovingPlatform1;
    public GameObject m_MovingPlatform2;

    public Transform m_Pos1_1;
    public Transform m_Pos1_2;
    public Transform m_Pos2_1;
    public Transform m_Pos2_2;

    private Vector3 m_NextPos1;
    private Vector3 m_NextPos2;

    private float m_Speed = 3f;

    void Awake()
    {
        m_NextPos1 = m_Pos1_1.position;
        m_NextPos2 = m_Pos2_2.position;
    }


    void Update()
    {
        if(m_MovingPlatform1.transform.position == m_Pos1_1.position) {
            m_NextPos1 = m_Pos1_2.position;
        }
        else if (m_MovingPlatform1.transform.position == m_Pos1_2.position) {
            m_NextPos1 = m_Pos1_1.position;
        }

        if (m_MovingPlatform2.transform.position == m_Pos2_1.position) {
            m_NextPos2 = m_Pos2_2.position;
        }
        else if (m_MovingPlatform2.transform.position == m_Pos2_2.position) {
            m_NextPos2 = m_Pos2_1.position;
        }

        m_MovingPlatform1.transform.position = Vector3.MoveTowards(m_MovingPlatform1.transform.position, m_NextPos1, m_Speed * Time.deltaTime);
        m_MovingPlatform2.transform.position = Vector3.MoveTowards(m_MovingPlatform2.transform.position, m_NextPos2, m_Speed * Time.deltaTime);
    }
}
