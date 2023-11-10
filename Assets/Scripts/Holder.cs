using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{

    public GameObject orbHolderAqua;
    public GameObject orbHolderBlue;
    public GameObject orbHolderPurple;
    public Notes notes;

    private Inventory inventory;
    private bool inTrigger;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
            Debug.Log("Trigger is:" + inTrigger);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
            Debug.Log("Trigger is:" + inTrigger);
        }
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (inTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(orbHolderAqua);
                notes.d.Play();
                Destroy(gameObject);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(orbHolderPurple);
                notes.c.Play();
                Destroy(gameObject);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(orbHolderBlue);
                notes.e.Play();
                Destroy(gameObject);
            }
        }
    }
}
