using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int elma = 0;

    [SerializeField] private Text elmaText;
    [SerializeField] private AudioSource toplamaSes;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Elma"))
        {
            toplamaSes.Play();
            Destroy(collision.gameObject);
            elma++;
            elmaText.text = " elmalar : " + elma;
                 
        }
    }
     
}
