using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer m_SpriteRenderer;
    private Rigidbody2D m_RigitBody;

    private float m_MovementSpeed = 6f;
    private float m_Acceleration = 1f;
    private float m_JumpForce = 12f;

    private void Awake()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_RigitBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Movement
        float movement = Input.GetAxis("Horizontal");
        
        // For acceleration
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            m_Acceleration = 5f;
        }
        else
        {
            m_Acceleration = 1f;
        }

        if (movement < 0) {
            m_SpriteRenderer.flipX = true;
        }
        else if(movement > 0)
        {
            m_SpriteRenderer.flipX = false;
        }

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * m_MovementSpeed * m_Acceleration;

        bool jump = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);

        if (jump && Mathf.Abs(m_RigitBody.velocity.y) == 0f)
        {
            m_RigitBody.AddForce(new Vector2(0, m_JumpForce), ForceMode2D.Impulse);
        }
    }
}
