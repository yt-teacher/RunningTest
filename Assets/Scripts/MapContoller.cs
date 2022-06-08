using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapContoller : MonoBehaviour
{
    // �萔
    public const int MaxStageCount = 10;
    public const float StageWidth = 25f;

    // �v���n�u�i�[��
    [SerializeField]
    private Transform parent;

    // �ϒ��z��F���X�g
    // Unity��ɕ\���\
    [SerializeField]
    private List<GameObject> stagePrefabList;

    // �ϒ��z��F���X�g
    // �X�N���v�g�Ŏg�p����ۂ̋L�q�@
    private List<GameObject> stageList = new List<GameObject>();

    public void Init()
    {
        // ���X�g�̎g������
        //// �ǉ�
        // List<int> tempList = new List<int>();
        //tempList.Add(0);
        //tempList.Add(10);
        //tempList.Add(5);
        //// �폜
        //tempList.RemoveAt(1);
        //// �\�[�g
        //tempList.Sort();
        //// �Z�b�g
        //tempList[0] = 1;
        //// for
        //for (int i = 0; i < tempList.Count; i++)
        //{
        //    tempList[i] = 1;
        //}
        //// �S����
        //tempList.Clear();

        // ���I�� Stage ��g�ݍ��킹�č��
        for (int i = 0; i < MaxStageCount; i++)
        {
            var index = Random.Range(0, stagePrefabList.Count);
            var stage = Instantiate(stagePrefabList[index], parent).transform;
            stage.localPosition = Vector3.forward * i * StageWidth;

            stageList.Add(stage.gameObject);
        }
    }

    public void OnUpdate()
    {
    }
}
