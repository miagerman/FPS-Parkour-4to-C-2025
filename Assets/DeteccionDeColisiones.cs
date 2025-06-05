using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
<<<<<<< HEAD
=======
    // Start is called before the first frame update
>>>>>>> 58a756213431fa7f86a843f07946460a7ff738fd
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
<<<<<<< HEAD
=======

>>>>>>> 58a756213431fa7f86a843f07946460a7ff738fd
}
