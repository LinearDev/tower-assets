using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Публические данные: хп,мана,лвл
    public int hp = 1000;
    public float mana = 100;
    public float lvl = 1;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Запуск функции, вызов тела или типо того
    }

    void Update()
    {

    }
    void TakeDamage(Collision shit) // Должно отвечать за снижение хп при столкновении, но чёт нихуя не работает
    {
        if (shit.gameObject.tag == "Enemy")
        {
            hp -= 100;
        }
    }
    void OnGUI() // Для вывода менюшки с хп
    {
        GUI.Box(new Rect(0, 0, 100, 30), "hp = " + hp); // 0 и 0 это корды, дальше размер 100х30, и дальше hp = [1000]
    }
}
