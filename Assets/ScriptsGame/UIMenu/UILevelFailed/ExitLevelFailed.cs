using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevelFailed : MonoBehaviour
{
    private void Update()
    {
        int health = PlayerPrefs.GetInt("Health");
        Debug.Log("Health " + health);
    }
}
