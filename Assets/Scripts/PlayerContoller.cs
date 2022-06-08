using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField]
    private Rigidbody body;

    [SerializeField]
    private float moveSpeed = 10f;

    [SerializeField]
    private float forwardSpeed = 10f;

    /// <summary>
    /// ����������
    /// </summary>
    public void Init()
    {
        body.useGravity = true;
    }

    /// <summary>
    /// �X�V����
    /// </summary>
    public void OnUpdate()
    {
        // ���������̓��͗�(-1f~1f)
        // �����ړ�
        var dir = Input.GetAxis("Horizontal");
        var moveDir = Vector3.right * dir;
        var velocity = moveDir * moveSpeed;
        velocity.y = body.velocity.y;

        // �O�����Ɉړ�
        velocity.z += Time.deltaTime * forwardSpeed;

        // �ړ��ʂ� velocity �ɃZ�b�g
        body.velocity = velocity;
    }
}
