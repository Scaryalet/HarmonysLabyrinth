using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrbController : MonoBehaviour
{

    public Notes notes;

    //What I need to figure out. Currently player collides with orb, note plays, orb is gone.
    //Instead, orb needs to go in inventory, searches for free slot, displays sprite.

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
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemUi, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
            if (this.tag == "orbPurple")
            {
                notes.c.Play();
            }
            else if (this.tag == "orbAqua")
            {
                notes.d.Play();
            }
            else if (this.tag == "orbBlue")
            {
                notes.e.Play();
            }
            
        }
    }
}
