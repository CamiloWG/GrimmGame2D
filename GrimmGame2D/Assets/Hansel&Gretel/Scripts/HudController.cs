using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public int totalPuntaje = 0;
    public GameObject hanselPlayer;
    public GameObject gretelPlayer;
    public Sprite emptyHeart;

    public Image gretelHeart;
    public Image hanselHeart;

    public TextMeshProUGUI textPuntaje;

    private PlayerInfo hanselInfo;
    private PlayerInfo gretelInfo;
    // Start is called before the first frame update
    void Start()
    {
        hanselInfo = hanselPlayer.GetComponent<PlayerInfo>();
        gretelInfo = gretelPlayer.GetComponent<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        totalPuntaje = gretelInfo.puntaje + hanselInfo.puntaje;
        textPuntaje.text = totalPuntaje.ToString();
        if(!gretelInfo.isAlive) gretelHeart.sprite = emptyHeart;
        if(!hanselInfo.isAlive) hanselHeart.sprite = emptyHeart;
        if(!hanselInfo.isAlive && !gretelInfo.isAlive)
        {
            StartCoroutine(GameOverRoutine());
        }
    }

    System.Collections.IEnumerator GameOverRoutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
    }
}
