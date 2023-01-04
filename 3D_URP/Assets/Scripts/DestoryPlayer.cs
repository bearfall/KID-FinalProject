using UnityEngine;

public class DestoryPlayer : MonoBehaviour
{
    [SerializeField, Header("會造成傷害的目標")]
    private string nameTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        print("碰撞:" + other.gameObject);
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
