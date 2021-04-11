using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public GameObject textUI;
    private TextMeshProUGUI textMesh;
    private Animator anim;
    // Start is called before the first frame update

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        StartCoroutine(TextIntro());
    }

    IEnumerator TextIntro()
    {
        anim.SetBool("visible", true);
        textMesh.text = "Em um dia qualquer você se ve livre de sua gaiola...";
        yield return new WaitForSeconds(4f);
        anim.SetBool("visible", false);

        yield return new WaitForSeconds(1.5f);

        anim.SetBool("visible", true);
        textMesh.text = "Você não entende o porque, ou como aconteceu...";
        yield return new WaitForSeconds(4f);
        anim.SetBool("visible", false);

        yield return new WaitForSeconds(1.5f);

        anim.SetBool("visible", true);
        textMesh.text = "Mas você está livre! E a liberdade deve ser compartilhada...";
        yield return new WaitForSeconds(4f);
        anim.SetBool("visible", false);

        yield return new WaitForSeconds(1.5f);

        anim.SetBool("visible", true);
        textMesh.text = "Querer ser livre é também querer livres os outros.\n~ Simone de Beauvoir";
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("map1");
    }
}
