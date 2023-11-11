using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject incorrect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.FindGameObjectWithTag("Holder1Purple").activeInHierarchy)
        {
            if (GameObject.FindGameObjectWithTag("Holder2Aqua").activeInHierarchy)
            {
                if (GameObject.FindGameObjectWithTag("Holder3Blue").activeInHierarchy)
                {
                    SceneManager.LoadScene(4);
                }
            }
        }
    }
}
