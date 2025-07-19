using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public DialogManager dialogManager;
    public PauseManager pauseManager;

    public DayState dayState = DayState.Day;


    [Header("Goods")]
    public int Water;
    public int Shine;
    public int MemoryPiece;

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

}
