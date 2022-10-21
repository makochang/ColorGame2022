using UnityEngine;

[RequireComponent(typeof(CharacterColor))]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    CharacterColor characterColor;
    Rigidbody rBody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().Damage(characterColor.GetCurrentColor());
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        characterColor = GetComponent<CharacterColor>();
        characterColor.SetColor(0);
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚çF‚ğ•Ï‚¦‚é
        if (Input.GetButtonDown("Fire1"))
        {
            characterColor.SetNextColor();
        }
        
        //“ü—Í‚ÉŠî‚Ã‚¢‚ÄˆÚ“®‚·‚é
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveVec = new Vector3(h, 0f, v);
        moveVec=moveVec.normalized;
        rBody.AddForce(moveVec);
    }
}
