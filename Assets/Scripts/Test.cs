using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //public int num;
    [SerializeField]
    private float ballSpeed = 10;

    [SerializeField]
    private GameObject plane;

    [SerializeField]
    private Rigidbody rigidBody;

    private void Awake()
    {
        //rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // �X�y�[�X����������o�E���h�~�܂�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            rigidBody.velocity = Vector3.up * ballSpeed;
        }
    }
}
