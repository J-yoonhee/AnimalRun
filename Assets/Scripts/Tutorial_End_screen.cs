using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_End_screen : MonoBehaviour
{
    public GameObject Endscreen;
    public static bool isClear = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Endscreen.gameObject.SetActive(true);
            Movement.Started = false;
            Movement.isAlive = false;
            isClear = true;

        }
    }
}
