using UnityEngine;

public class DestoryPlayer : MonoBehaviour
{
    [SerializeField, Header("�|�y���ˮ`���ؼ�")]
    private string nameTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        print("�I��:" + other.gameObject);
        if (other.gameObject.name.Contains(nameTarget))
        {
            
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
