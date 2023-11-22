using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour
{
    [SerializeField]                               // Два різні способи одержати
    private TMPro.TextMeshProUGUI pipesPassedTmp;  // доступ до елементів сцени
                                                   // (у т.ч. UI) - через link
    private TMPro.TextMeshProUGUI clock;           // або через пошук

    [SerializeField]
    private Image vitalityIndicator;

    private float gameTime;

    void Start()
    {
        // Link - встановлення зв'язку за допомогою Editor, код не потрібен
        // Пошук - Знайти компонент TextMeshProUGUI у іншого GameObject "ClockTMP"
        clock = GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();

        vitalityIndicator.fillAmount = 1f;  // повне "життя" на початку гри

        gameTime = 0;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
    }

    private void LateUpdate()
    {
        int time = (int)gameTime;
        int hour = time / 3600;
        int minute = (time % 3600) / 60;
        int second = time % 60;
        int decisecond = (int)( (gameTime - time) * 10 );
        clock.text = $"{hour:00}:{minute:00}:{second:00}.{decisecond:0}";

        pipesPassedTmp.text = GameState.pipesPassed.ToString();
    }
}
/* Д.З. Реалізувати зміну індикатора життєвої сили
 * з міркувань 20-30 секунд на повне вичерпання.
 * При досягненні нуля вивести повідомлення у консоль
 * і припинити зменшення fillAmount
 */
