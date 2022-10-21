using UnityEngine;

[RequireComponent(typeof(CharacterColor))]
public class Enemy : MonoBehaviour
{
    GameManager gm;

    public int myScore = 100;

    public GameObject parent;

    CharacterColor characterColor;


    public void Damage(int index)
    {
        if (characterColor.CheckSameColor(index))
        {
            gm.AddScore(myScore);
            //parent.GetComponent<Spawner>().Bye();
            Destroy(gameObject);
        }
    }

    public void SetParent(GameObject po)
    {
        parent = po;
    }

    // Start is called before the first frame update
    void Start()
    {
        characterColor = GetComponent<CharacterColor>();
        characterColor.SetRandomColor();
        gm = GameObject.Find("GM").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
