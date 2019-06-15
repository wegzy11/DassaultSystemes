using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextColorButtonScript : MonoBehaviour
{
    //Resource: Unity Docs to assist with switch and material syntax

    int mat = -1;
    public GameObject spinningObject;
    Material _material;

    // Start is called before the first frame update
    void Start()
    {
        _material = spinningObject.GetComponent<Renderer>().material;
        _material.color = Color.blue;
    }

    //When button clicked, switches to next material in list
    public void NextMaterial()
    {
        mat++;
        //mat % 3 loops 0, 1, and 2 as mat increments
        int matCount = mat % 3;

        switch (matCount)
            {
            case 0:
                _material.color = Color.red;
                break;
            case 1:
                _material.color = Color.green;
                break;
            case 2:
                _material.color = Color.blue;
                break;
        }
    }

    //yellow function called from playButtonScript which is linked to VideoPlayer
    public void OnVideoLoop()
    {
        _material.color = Color.yellow;
    }
}
