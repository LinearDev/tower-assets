using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // ����������� ������: ��,����,���
    public int hp = 1000;
    public float mana = 100;
    public float lvl = 1;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // ������ �������, ����� ���� ��� ���� ����
    }

    void Update()
    {

    }
    void TakeDamage(Collision shit) // ������ �������� �� �������� �� ��� ������������, �� ��� ����� �� ��������
    {
        if (shit.gameObject.tag == "Enemy")
        {
            hp -= 100;
        }
    }
    void OnGUI() // ��� ������ ������� � ��
    {
        GUI.Box(new Rect(0, 0, 100, 30), "hp = " + hp); // 0 � 0 ��� �����, ������ ������ 100�30, � ������ hp = [1000]
    }
}
