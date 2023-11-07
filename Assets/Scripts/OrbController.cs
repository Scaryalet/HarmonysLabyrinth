using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrbController : MonoBehaviour
{

    public Notes notes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
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

            Destroy(gameObject);
        }
    }
}
