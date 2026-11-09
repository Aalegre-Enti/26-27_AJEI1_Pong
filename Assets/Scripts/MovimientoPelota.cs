using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dir = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
            );
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He atravesado: " + collision.gameObject.name);
    }
}
