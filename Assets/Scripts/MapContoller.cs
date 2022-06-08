using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapContoller : MonoBehaviour
{
    // 定数
    public const int MaxStageCount = 10;
    public const float StageWidth = 25f;

    // プレハブ格納先
    [SerializeField]
    private Transform parent;

    // 可変長配列：リスト
    // Unity上に表示可能
    [SerializeField]
    private List<GameObject> stagePrefabList;

    // 可変長配列：リスト
    // スクリプトで使用する際の記述法
    private List<GameObject> stageList = new List<GameObject>();

    public void Init()
    {
        // リストの使い方例
        //// 追加
        // List<int> tempList = new List<int>();
        //tempList.Add(0);
        //tempList.Add(10);
        //tempList.Add(5);
        //// 削除
        //tempList.RemoveAt(1);
        //// ソート
        //tempList.Sort();
        //// セット
        //tempList[0] = 1;
        //// for
        //for (int i = 0; i < tempList.Count; i++)
        //{
        //    tempList[i] = 1;
        //}
        //// 全消し
        //tempList.Clear();

        // 動的に Stage を組み合わせて作る
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
