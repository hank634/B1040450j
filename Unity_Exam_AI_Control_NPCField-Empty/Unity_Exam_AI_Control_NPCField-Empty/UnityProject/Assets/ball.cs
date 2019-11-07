using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    [Header("對話")]
    public string 對話 = "給我汽油";
    public float 對話速度 = 1.5f;
    [Header("任務")]
    public bool 是否完成 = false;
    public int 數量 = 0;
    public int 需求 = 5;
}
