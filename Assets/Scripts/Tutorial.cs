using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject movementTutorial;
    public GameObject orbTutorial;
    public GameObject holderTutorial;

    public void HideMovement()
    {
        orbTutorial.SetActive(true);
        movementTutorial.SetActive(false);
    }
    public void HideOrbs()
    {
        orbTutorial.SetActive(false);
        holderTutorial.SetActive(true);

    }
}
