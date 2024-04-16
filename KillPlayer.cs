using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
{
    {
        //Om spelare nuddar fula kub. Ta tillbaka till start.
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }
}
}