using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
namespace bearfall
{

    public class DestoryPlayer : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        private PlayerInput playerInput;
        [SerializeField, Header("��ܫ���")]
        private KeyCode dialogueKey = KeyCode.R;
        
        void Start()
        {
            playerInput = GameObject.Find("PlayerCapsule").GetComponent<PlayerInput>();
            
        }
        private void OnCollisionEnter(Collision other)
        {
            print("�I��:" + other.gameObject);
            if (other.gameObject.name.Contains(nameTarget))
            {
                FinalManager.instance.GameOver("�C������");
                Replay();
                playerInput.enabled = false;
            }
        }
        private void Replay()
        {
            if (Input.GetKeyDown(dialogueKey))
            {
                print("�ګ��FR");
                SceneManager.LoadScene("�}�l���");
            }

        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}