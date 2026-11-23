using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    public GestorPuntuacion puntuacion;
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
            if (collision.gameObject.name == "Porteria A")
            {
                Debug.Log("El jugador B ha marcado al jugador A");

                puntuacion.puntuacionB = puntuacion.puntuacionB + 1;
            }
            if (collision.gameObject.name == "Porteria B")
            {
                Debug.Log("El jugador A ha marcado al jugador B");

                puntuacion.puntuacionA = puntuacion.puntuacionA + 1;
            }
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
