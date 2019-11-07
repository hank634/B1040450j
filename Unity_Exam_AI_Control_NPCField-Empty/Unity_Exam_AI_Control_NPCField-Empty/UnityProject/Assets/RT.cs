using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RT : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) { transform.Translate(0, 0, 1f); }

        if (Input.GetKeyDown(KeyCode.S)) { transform.Translate(0, 0, -1f); }

      

    }
}
