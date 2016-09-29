using UnityEngine;
using System.Collections;

public class botonCurvasDeNivel : MonoBehaviour {
    public Canvas CurvasDeNivelCanvas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MuestraMenu()
    {
        CurvasDeNivelCanvas.gameObject.SetActive(true);
    }
}
