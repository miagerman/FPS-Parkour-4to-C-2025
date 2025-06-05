using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
<<<<<<< HEAD
    public float cost;
    public MoneyManager moneyManager;

    void Start ()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // actualizar dinero por la compra
            moneyManager.UpdateMoney(-cost);
            Destroy(gameObject);
        }
        
=======
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
>>>>>>> 58a756213431fa7f86a843f07946460a7ff738fd
    }
}
