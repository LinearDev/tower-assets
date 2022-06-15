using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 5f;
    private Transform _rotate;
    private void Start()
    {
        _rotate = GetComponent<Transform>();
    }
    private void Update()
    {
        _rotate.Rotate(-2 * speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime);  
    }
}
