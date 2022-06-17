using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 10;
    public int hp = 20;
    private Transform locale;
    void Start()
    {
        locale = GetComponent<Transform>(); // ������ ��� ����� �������
    }

    void Update()
    {
        Vector3 pos = -transform.right; // ����� ������� � ����
        // ����� ������� �� ����� � ����� �� ��������
        transform.position = Vector3.MoveTowards(transform.position, transform.position + pos, speed * Time.deltaTime);
    }
}
