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
    /// 初期化処理
    /// </summary>
    public void Init()
    {
        body.useGravity = true;
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    public void OnUpdate()
    {
        // 水平方向の入力量(-1f~1f)
        // 水平移動
        var dir = Input.GetAxis("Horizontal");
        var moveDir = Vector3.right * dir;
        var velocity = moveDir * moveSpeed;
        velocity.y = body.velocity.y;

        // 前方向に移動
        velocity.z += Time.deltaTime * forwardSpeed;

        // 移動量を velocity にセット
        body.velocity = velocity;
    }
}
