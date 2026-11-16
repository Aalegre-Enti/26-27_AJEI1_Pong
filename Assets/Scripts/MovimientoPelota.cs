using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("He atravesado: " + collision.gameObject.tag);

        if (collision.gameObject.tag == "Horizontal")
        {
            dir.y = dir.y * -1;
        }
        if (collision.gameObject.tag == "Vertical")
        {
            dir.x = dir.x * -1;
        }
        if (collision.gameObject.tag == "Porteria")
        {
            transform.position = new Vector3(0, 0);
            Spawn();
        }
    }

    void Spawn()
    {
        Debug.Log("Ha spawneado la pelota");
        dir = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
            );

        if (dir.x > 0)
        {
            dir.x = 1;
        }
        else
        {
            dir.x = -1;
        }

        dir.Normalize();
    }
}
