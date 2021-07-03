using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoJugador : MonoBehaviour
{
    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(jugador.transform.position.x - 3, jugador.transform.position.z + 1f, jugador.transform.position.y);
    }
}
