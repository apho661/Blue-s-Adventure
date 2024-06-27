using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int strawberries = 0; 
    [SerializeField] private Text strawberriesText;

    [SerializeField] private AudioSource collectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Strawberry")) {
            
            Destroy(collision.gameObject);
            strawberries++;
            strawberriesText.text = "Strawberries: " + strawberries;
            collectSound.Play();
        }
    }
}
