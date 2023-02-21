using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int symbols = 0;

    [SerializeField] private Text symbolsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Simbolo"))
        {
            Destroy(collision.gameObject);
            symbols++;
            symbolsText.text = "Symbols" + symbols;
        }
    }

    
}
