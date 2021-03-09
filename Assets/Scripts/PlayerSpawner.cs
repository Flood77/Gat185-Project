using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject spawnGameObject;
    public int lives = 3;
    public GameSession gameS;
    public TextMeshProUGUI txtlives;

    void Update()
    {
        if (transform.childCount == 0) OnSpawn();
       
        txtlives.text = lives.ToString();
    }

    public void OnSpawn()
    {
        Transform parent = transform;
        Instantiate(spawnGameObject, transform.position, transform.rotation, parent);

        lives--;
        if (lives <= -1) gameS.State = GameSession.eState.GameOver;
    }
}
