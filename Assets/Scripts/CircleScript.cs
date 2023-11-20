using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private Rigidbody2D body;   // посилання на компонент

    void Start()
    {
        body = this.GetComponent<Rigidbody2D>();  // одержуємо посилання на компонент
    }

    // Раз у кадр
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * 250);
        }
    }
}
/* Встановити Юніті.
 * Створити 2D проєкт.
 * Розмістити об'єкти сцени, надати їх фізичні характеристики
 * (тіла та колайдери)
 * Налаштувати межі "ігрового поля"
 * Реалізувати керування об'єктом, перевірити, що він не
 * виходить за межі поля.
 * ** Розмістити додаткові об'єкти, перевірити їх взаємодію
 * Прикласти відео 
 */
