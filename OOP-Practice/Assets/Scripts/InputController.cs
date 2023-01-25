using UnityEngine;
using System;

public class InputController : MonoBehaviour
{

    public GameObject go;

    private IControllable controllableObject;

    private void Start()
    {
        controllableObject = go.GetComponent<IControllable>();

        if(controllableObject == null)
        {
            throw new NullReferenceException("go does not have IControllable interface");
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            controllableObject.Move();
        }
    }
}
