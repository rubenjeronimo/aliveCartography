using UnityEngine;
using System.Collections;

public class aguaBoton : MonoBehaviour {
    public Canvas AguaCanvas;
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
        AguaCanvas.gameObject.SetActive(true);
    }
}
