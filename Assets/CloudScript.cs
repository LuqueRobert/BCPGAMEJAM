using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{

    [SerializeField] private float _speed = 2;
    [SerializeField] private float _endPosX;

    // Start is called before the first frame update
    public void Start(float speed, float endPosX)
    {
        _speed = speed;
        _endPosX = endPosX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * _speed));

        if(transform.position.x > _endPosX)
        {
            Destroy(gameObject);
        }
    }
}
