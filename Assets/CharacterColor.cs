/// <summary>
/// 色を司るクラス
/// </summary>
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class CharacterColor : MonoBehaviour
{

    //色配列
    private Color[] colors = {
        Color.red,
        Color.green,
        Color.blue,
        new Color(1f,0f,1f)
    };

    int currentIndex;   //現在の色

    MeshRenderer meshRenderer;  //メッシュレンダラーへの参照

    /// <summary>
    /// 色を変更する
    /// </summary>
    private void ChangeColor()
    {
        if (meshRenderer == null)
        {
            //自身のメッシュレンダラーを取得する
            meshRenderer = GetComponent<MeshRenderer>();
        }
        meshRenderer.material.color = colors[currentIndex];
    }

    /// <summary>
    /// 色をランダムに変更する
    /// </summary>
    public void SetRandomColor()
    {
        currentIndex = Random.Range(0, colors.Length);
        ChangeColor();
    }

    /// <summary>
    /// 特定の色に変更する
    /// </summary>
    /// <param name="index">色番号</param>
    public void SetColor(int index)
    {
        if (index < colors.Length)
        {
            currentIndex = index;
        }
        else
        {
            currentIndex = 0;
        }
        ChangeColor();
    }

    /// <summary>
    /// 次の色に変更する
    /// </summary>
    public void SetNextColor()
    {
        currentIndex++;
        if (currentIndex >= colors.Length)
        {
            currentIndex = 0;
        }
        ChangeColor();
    }

    /// <summary>
    /// 色数を取得する
    /// </summary>
    /// <returns>色数</returns>
    public int GetNumOfColor()
    {
        return colors.Length;
    }

    /// <summary>
    /// 色を取得する
    /// </summary>
    /// <returns>現在の色</returns>
    public int GetCurrentColor()
    {
        return currentIndex;
    }

    /// <summary>
    /// 同色か否かをチェックする
    /// </summary>
    /// <param name="index"></param>
    /// <returns>可否</returns>
    public bool CheckSameColor(int index)
    {
        if (index == currentIndex)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Start()
    {
    }


}
