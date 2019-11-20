using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMaps : MonoBehaviour
{
    [SerializeField] float speed = 1.5f;
    [SerializeField] float startPos;
    [SerializeField] float detPos;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        if (transform.position.x < detPos)
        {
            transform.Translate(-1 * (detPos - startPos), 0, 0);
        }
    }
}
