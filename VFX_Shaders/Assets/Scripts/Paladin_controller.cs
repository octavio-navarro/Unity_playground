using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Paladin_controller : MonoBehaviour
{
    Animator animator;
    
    [SerializeField]
    public List<GameObject> slashes;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isSlashing", false);
    }

    void DisableSlashes()
    {
        foreach (GameObject slash in slashes)
        {
            slash.SetActive(false);
        }
    }

    IEnumerator Slash(int index)
    {
        slashes[index].SetActive(true);
        yield return new WaitForSeconds(1.0f);
        slashes[index].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !animator.GetBool("isSlashing1"))
        {
            animator.SetBool("isSlashing1", true);
        }
        if (Input.GetKeyDown(KeyCode.W) && !animator.GetBool("isSlashing2"))
        {
            animator.SetBool("isSlashing2", true);
        }
        if (Input.GetKeyDown(KeyCode.E) && !animator.GetBool("isSlashing3"))
        {
            animator.SetBool("isSlashing3", true);
        }
    }

    public void resetAttack()
    {
        animator.SetBool("isSlashing1", false);
        animator.SetBool("isSlashing2", false);
        animator.SetBool("isSlashing3", false);
        Debug.Log("Attack reset");
    }
}
