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
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
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
                if (inventory.isFull[0] == true)
                {
                    Instantiate(orbHolderAqua);
                    notes.d.Play();
                    inventory.isFull[0] = false;
                    Destroy(GameObject.FindWithTag("SpriteAqua"));
                    Destroy(gameObject);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (inventory.isFull[1] == true)
                {
                    Instantiate(orbHolderPurple);
                    notes.c.Play();
                    inventory.isFull[1] = false;
                    Destroy(GameObject.FindWithTag("SpritePurple"));
                    Destroy(gameObject);
                }
                    
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (inventory.isFull[2] == true)
                {
                    Instantiate(orbHolderBlue);
                    notes.e.Play();
                    inventory.isFull[2] = false;
                    Destroy(GameObject.FindWithTag("SpriteBlue"));
                    Destroy(gameObject);
                }
                    
            }
        }
    }
}
