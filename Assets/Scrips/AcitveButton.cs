using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcitveButton : MonoBehaviour
{
    public GameObject button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button.SetActive(true);
        }
    }
}
