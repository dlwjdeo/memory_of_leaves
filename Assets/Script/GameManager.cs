using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Goods")]
    public int Water;

    [Header("Leaves")]
    public GameObject[] Leaves;
}
