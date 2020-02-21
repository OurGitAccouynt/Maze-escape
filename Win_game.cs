using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_game : MonoBehaviour
{
    public string level_name;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel(level_name);
        }
    }

}
