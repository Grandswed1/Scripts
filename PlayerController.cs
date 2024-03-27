using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 inputVector;

    [SerializeField]
    float speed = 5;

    void Update()
    {
        transform.Translate(inputVector * speed * Time.deltaTime);
    }

    void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector>();
    }

}