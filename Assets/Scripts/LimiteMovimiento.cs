using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float limiteMax = 4;
    public float limiteMin = -4;

    void Update()
    {
        if (transform.position.y > limiteMax) //El objeto se pasa por encima del limite maximo?
        {
            Vector3 newpos = transform.position; //Guardo la posicion actual en una variable
            newpos.y = limiteMax; //modifico la y de la posicion guardada
            transform.position = newpos; //aplico la posicion guardada a la posicion del objeto
        }
        if (transform.position.y < limiteMin) //El objeto se pasa por encima del limite maximo?
        {
            Vector3 newpos = transform.position; //Guardo la posicion actual en una variable
            newpos.y = limiteMin; //modifico la y de la posicion guardada
            transform.position = newpos; //aplico la posicion guardada a la posicion del objeto
        }
    }
}
