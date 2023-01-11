using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
namespace bearfall
{
    /// <summary>
    /// ���ʨt��:�������a�O�_�i�J�åB���椬�ʦ欰
    /// </summary>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("�Ĥ@�q��ܸ��")]
        private DialogueData dataDialogue;
        [SerializeField, Header("��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinish;
        [SerializeField, Header("�ҰʹD��")]
        private GameObject propActive;
        [SerializeField, Header("�Ұʫ᪺��ܸ��")]
        private DialogueData dataDialogueActive;
        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;
        
        [SerializeField, Header("�Ұʫ��ܵ����᪺�ƥ�")]
        private UnityEvent onDialogueFinishAfterActive;


        private void Awake()
        {
            dialogueSystem = GameObject.Find("�e����ܨt��").GetComponent<DialogueSystem>();
        }

        public void HitByRaycast() //�Q�g�u����ɷ|�i�J����k
        {
            if (Input.GetKeyDown(KeyCode.E)) //����U��L E ���
            {
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name.Contains(nameTarget))
            {
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive, onDialogueFinishAfterActive);
                }
            }
        }
        

        
        // Start is called before the first frame update
        

        

        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }
    }
}