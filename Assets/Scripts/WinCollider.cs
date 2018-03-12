using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCollider : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        LevelManager levelManager = new LevelManager();
        levelManager.LoadLevel("Win");
    }
}
