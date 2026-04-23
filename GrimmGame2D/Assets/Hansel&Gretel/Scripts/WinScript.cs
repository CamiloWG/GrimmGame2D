using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{   
    private bool win = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(win) return;
        if(collision.CompareTag("Player"))
        {
            AudioController.instance.PlayWin();
            win = true;
            StartCoroutine(WinRoutine());
        }
    }

    System.Collections.IEnumerator WinRoutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(3);
    }
}
