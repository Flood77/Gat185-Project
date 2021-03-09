using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    static GameSession instance = null;
    public static GameSession Instance
    {
        get
        {
            return instance;
        }
    }

    public enum eState
    {
        StartSession, 
        Session,
        EndSession,
        GameOver
    }

    public eState State { get; set; } = eState.StartSession;

    private void Awake()
    {
        instance = this;   
    }

    private void Update()
    {
        switch (State)
        {
            case eState.StartSession:
                State = eState.Session;
                break;
            case eState.Session:
                break;
            case eState.EndSession:
                break;
            case eState.GameOver:
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene("KeepAwayMenu");
                break;
            default:
                break;
        }
    }
}
