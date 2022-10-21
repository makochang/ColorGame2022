/// <summary>
/// �F���i��N���X
/// </summary>
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
public class CharacterColor : MonoBehaviour
{

    //�F�z��
    private Color[] colors = {
        Color.red,
        Color.green,
        Color.blue,
        new Color(1f,0f,1f)
    };

    int currentIndex;   //���݂̐F

    MeshRenderer meshRenderer;  //���b�V�������_���[�ւ̎Q��

    /// <summary>
    /// �F��ύX����
    /// </summary>
    private void ChangeColor()
    {
        if (meshRenderer == null)
        {
            //���g�̃��b�V�������_���[���擾����
            meshRenderer = GetComponent<MeshRenderer>();
        }
        meshRenderer.material.color = colors[currentIndex];
    }

    /// <summary>
    /// �F�������_���ɕύX����
    /// </summary>
    public void SetRandomColor()
    {
        currentIndex = Random.Range(0, colors.Length);
        ChangeColor();
    }

    /// <summary>
    /// ����̐F�ɕύX����
    /// </summary>
    /// <param name="index">�F�ԍ�</param>
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
    /// ���̐F�ɕύX����
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
    /// �F�����擾����
    /// </summary>
    /// <returns>�F��</returns>
    public int GetNumOfColor()
    {
        return colors.Length;
    }

    /// <summary>
    /// �F���擾����
    /// </summary>
    /// <returns>���݂̐F</returns>
    public int GetCurrentColor()
    {
        return currentIndex;
    }

    /// <summary>
    /// ���F���ۂ����`�F�b�N����
    /// </summary>
    /// <param name="index"></param>
    /// <returns>��</returns>
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
