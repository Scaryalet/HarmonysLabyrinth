using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;

    public void ContinueOne()
    {
        one.SetActive(false);
        two.SetActive(true);
    }
    public void ContinueTwo()
    {
        two.SetActive(false);
        three.SetActive(true);
    }
    public void ContinueThree()
    {
        three.SetActive(false);
        four.SetActive(true);
    }
    public void ContinueFour()
    {
        SceneManager.LoadScene(3);
    }
}
