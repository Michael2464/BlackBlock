using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decoration5 : MonoBehaviour
{
    public GameObject m_MovingBlockRight;
    public GameObject m_MovingBlockLeft;

    public Transform m_PosRight;
    public Transform m_PosLeft;

    public Vector3 m_InitPosRight;
    public Vector3 m_InitPosLeft;

    public bool is_Moving = false;
    private float m_Speed = 5.3f;

    private void Awake()
    {
        m_InitPosRight = m_MovingBlockRight.transform.position;
        m_InitPosLeft = m_MovingBlockLeft.transform.position;
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

    // Update is called once per frame
    void Update()
    {
        if (is_Moving)
        {
            m_MovingBlockRight.transform.position = Vector3.MoveTowards(m_MovingBlockRight.transform.position, m_PosRight.position, m_Speed * Time.deltaTime);
            m_MovingBlockLeft.transform.position = Vector3.MoveTowards(m_MovingBlockLeft.transform.position, m_PosLeft.position, m_Speed * Time.deltaTime);
        }
    }
}
