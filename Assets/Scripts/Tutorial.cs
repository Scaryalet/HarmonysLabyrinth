using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject movementTutorial;
    public GameObject orbTutorial;
    public GameObject holderTutorial;
    public GameObject portalTutorial;
    public GameObject levelStart;

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

    public void HideHolders()
    {
        holderTutorial.SetActive(false);
        portalTutorial.SetActive(true);
    }

    public void HidePortals()
    {
        portalTutorial.SetActive(false);
        levelStart.SetActive(true );
    }
}
