using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int speed = 5;
    public int health=100;
    // Start is called before the first frame update
    void Start()
    {
        //�������� ���
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        //��������
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
