using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrbController : MonoBehaviour
{

    public Notes notes;


    private Inventory inventory;
    public GameObject itemUi;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.tag == "orbPurple")
            {
                Instantiate(itemUi, inventory.slots[1].transform, false);
                notes.c.Play();
                Destroy(gameObject);
            }
            else if (this.tag == "orbAqua")
            {
                Instantiate(itemUi, inventory.slots[0].transform, false);
                notes.d.Play();
                Destroy(gameObject);
            }
            else if (this.tag == "orbBlue")
            {
                Instantiate(itemUi, inventory.slots[2].transform, false);
                notes.e.Play();
                Destroy(gameObject);
            }
        }
    }
}
