using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public DialogManager dialogManager;

    public bool isPaused;

    [Header("Goods")]
    public int Water;
    public int Shine;

    [Header("Leaves")]
    public GameObject[] Leaves;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPause(bool pause)
    {
        isPaused = pause;
        if (isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
