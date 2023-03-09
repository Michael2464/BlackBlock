using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public Decoration4 decorations4;
    public Decoration5 decorations5;

    public GameObject m_Camera;
    public GameObject m_CameraBorders;
    public GameObject m_Background;
    public GameObject m_ScaryBackground;
    public GameObject m_ScaryImage;

    public GameObject m_NormalAudio;
    public GameObject m_ScaryAudio;
    public GameObject m_ScaryVoicesAudio;
    public GameObject m_ScaryScreamAudio;

    public GameObject m_Decorations1;
    public GameObject m_UpSpikes1;
    public GameObject m_StartPos1;
    public GameObject m_EndPos1;

    public GameObject m_Decorations2;
    public GameObject m_OpenningPlatform2;
    public Transform m_OpenningPlatformNextPos;
    public Transform m_ButtonRedPartNextPos;

    public GameObject m_Decorations3;
    public GameObject m_Decorations4;
    public GameObject m_Decorations5;
    public GameObject m_Decorations6;
    public GameObject m_Decorations7;
    public GameObject m_Decorations8;


    private Vector3 m_CameraPos1 = new Vector3(0f, 0f, -10f);
    private Vector3 m_CameraPos2 = new Vector3(17.86f, 0f, -10f);
    private Vector3 m_CameraPos3 = new Vector3(35.7f, 0f, -10f);
    private Vector3 m_CameraPos4 = new Vector3(53.8f, 0f, -10f);
    private Vector3 m_CameraPos5 = new Vector3(74.43f, 0f, -10f);
    private Vector3 m_CameraPos6 = new Vector3(74.39f, -28.93f, -10f);
    private Vector3 m_CameraPos7 = new Vector3(92.25f, -28.93f, -10f);
    private Vector3 m_CameraPos8 = new Vector3(110.01f, -29f, -10f);

    private Vector3 m_PlayerPos1 = new Vector3(-6.96f, -3.895f, 0f);
    private Vector3 m_PlayerPos2 = new Vector3(10.3f, 2.8f, 0f);
    private Vector3 m_PlayerPos3 = new Vector3(27.73f, -4.242f, 0f);
    private Vector3 m_PlayerPos4 = new Vector3(45.6f, -0.69755f, 0f);
    private Vector3 m_PlayerPos5 = new Vector3(66.34f, -0.69755f, 0f);
    private Vector3 m_PlayerPos6 = new Vector3(72.1f, -31.43f, 0f);
    private Vector3 m_PlayerPos7 = new Vector3(84.23f, -31.43f, 0f);
    private Vector3 m_PlayerPos8 = new Vector3(102.35f, -31.43f, 0f);

    private Vector3 m_CurrentPlayerSpawnPos;

    private bool is_MovingPlatformActive1 = false;
    private float m_Speed = 0.5f;

    private void Awake()
    {
        m_Decorations1.SetActive(true);
        m_Decorations2.SetActive(false);
        m_Decorations3.SetActive(false);
        m_Decorations4.SetActive(false);
        m_Decorations5.SetActive(false);
        m_Decorations6.SetActive(false);
        m_Decorations7.SetActive(false);
        m_Decorations8.SetActive(false);

        m_NormalAudio.SetActive(true);
        m_ScaryAudio.SetActive(false);
        m_ScaryVoicesAudio.SetActive(false);
        m_ScaryScreamAudio.SetActive(false);

        m_ScaryImage.SetActive(false);
        m_ScaryBackground.SetActive(false);

        m_Camera.transform.position = m_CameraPos1;
        m_CurrentPlayerSpawnPos = m_PlayerPos1;
        transform.position = m_CurrentPlayerSpawnPos;

        m_UpSpikes1.transform.position = m_StartPos1.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.name)
        {
            case "Transfer1":
            {
                m_Decorations2.SetActive(true);
                m_Decorations1.SetActive(false);

                m_Camera.transform.position = m_CameraPos2;
                m_CurrentPlayerSpawnPos = m_PlayerPos2;
                transform.position = m_CurrentPlayerSpawnPos;

                m_Background.transform.position += new Vector3(-0.5f, 0.0f, 0.0f);
                break;
            }
            case "Transfer2":
                {
                    m_Decorations2.SetActive(false);
                    m_Decorations3.SetActive(true);

                    m_Camera.transform.position = m_CameraPos3;
                    m_CurrentPlayerSpawnPos = m_PlayerPos3;
                    transform.position = m_CurrentPlayerSpawnPos;

                    m_Background.transform.position += new Vector3(-0.5f, 0.0f, 0.0f);
                    break;
                }
            case "Transfer3":
                {
                    m_Decorations3.SetActive(false);
                    m_Decorations4.SetActive(true);

                    m_Camera.transform.position = m_CameraPos4;
                    m_CurrentPlayerSpawnPos = m_PlayerPos4;
                    transform.position = m_CurrentPlayerSpawnPos;

                    m_Background.transform.position += new Vector3(-0.5f, 0.0f, 0.0f);
                    break;
                }
            case "Transfer4":
                {
                    m_Decorations4.SetActive(false);
                    m_Decorations5.SetActive(true);

                    m_Camera.transform.position = m_CameraPos5;
                    m_CurrentPlayerSpawnPos = m_PlayerPos5;
                    transform.position = m_CurrentPlayerSpawnPos;

                    m_Background.transform.position += new Vector3(-0.5f, 0.0f, 0.0f);
                    break;
                }
            case "Trigger_C":
                {
                    m_Camera.transform.position = m_CameraPos6;
                    m_Background.SetActive(false);
                    m_ScaryBackground.SetActive(true);

                    m_Decorations5.SetActive(false);
                    m_Decorations6.SetActive(true);

                    m_CurrentPlayerSpawnPos = m_PlayerPos6;

                    m_NormalAudio.SetActive(false);
                    m_ScaryAudio.SetActive(true);

                    break;
                }
            case "Transfer7":
                {
                    m_Camera.transform.position = m_CameraPos7;
                    m_Decorations6.SetActive(false);
                    m_Decorations7.SetActive(true);

                    m_CurrentPlayerSpawnPos = m_PlayerPos7;
                    transform.position = m_CurrentPlayerSpawnPos;

                    break;
                }
            case "Transfer8":
                {
                    m_Camera.transform.position = m_CameraPos8;
                    m_Decorations7.SetActive(false);
                    m_Decorations8.SetActive(true);
                    m_ScaryVoicesAudio.SetActive(true);

                    m_CurrentPlayerSpawnPos = m_PlayerPos8;
                    transform.position = m_CurrentPlayerSpawnPos;

                    break;
                }

            case "TriggerToScreamer":
                {
                    m_ScaryVoicesAudio.SetActive(false);
                    m_ScaryAudio.SetActive(false);

                    m_ScaryScreamAudio.SetActive(true);
                    m_ScaryImage.SetActive(true);

                    m_Decorations8.SetActive(false);

                    break;
                }

            case "TriggerForUpSpikes":
                {
                    m_UpSpikes1.transform.position = Vector3.MoveTowards(m_UpSpikes1.transform.position, m_EndPos1.transform.position, 20f);
                    StartCoroutine(Wait());
                    break;
                }
            case "Trigger_C_1":
                {
                    m_CameraBorders.SetActive(false);
                    break;
                }
            case "Trigger_C_2":
                {
                    m_CameraBorders.SetActive(true);
                    break;
                }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "Obstacle":
            {
                    if (m_Decorations4.activeSelf)
                    {
                        decorations4.is_Moving = false;
                        decorations4.m_MovingPlatform1.transform.position = decorations4.m_InitPos1;
                        decorations4.m_MovingPlatform2.transform.position = decorations4.m_InitPos2;

                    }
                    if (m_Decorations5.activeSelf)
                    {
                        decorations5.is_Moving = false;
                        decorations5.m_MovingBlockRight.transform.position = decorations5.m_InitPosRight;
                        decorations5.m_MovingBlockLeft.transform.position = decorations5.m_InitPosLeft;
                    }

                    transform.position = m_CurrentPlayerSpawnPos;
                    //m_UpSpikes1.transform.position = m_StartPos1.transform.position;
                    break;
            }
            case "MovingPlatform":
                {
                    transform.parent = collision.gameObject.transform;
                    break;
                }
            case "Button":
                {
                    is_MovingPlatformActive1 = true;
                    collision.gameObject.transform.position = m_ButtonRedPartNextPos.position;
                    break;
                }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        m_UpSpikes1.transform.position = m_StartPos1.transform.position;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        switch (collision.collider.tag)
        {
            case "MovingPlatform":
                {
                    transform.parent = null;
                    break;
                }
        }
    }

    private void Update() 
    {
        if (is_MovingPlatformActive1)
        {
            m_OpenningPlatform2.transform.position = Vector3.MoveTowards(m_OpenningPlatform2.transform.position, m_OpenningPlatformNextPos.position, m_Speed * Time.deltaTime);
        }
    }
}
