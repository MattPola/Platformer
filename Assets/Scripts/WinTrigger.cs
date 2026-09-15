using System;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.Win();
            Debug.Log("you win!");
        }
    }
}
