using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using TMPro;

public class Text_reveal : MonoBehaviour {

    private TextMeshPro m_textMeshPro;
    public GameObject rules;
    GameObject story;

    IEnumerator Start()
    {
        m_textMeshPro = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        int totalVisibleCharacters = m_textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);

            m_textMeshPro.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacters || Input.GetMouseButton(0) )
            {
                story = GameObject.FindWithTag("Story");
                story.SetActive(false);
                rules.SetActive(true);
            }

            counter += 1;
            yield return new WaitForSeconds(0.05f);

        }

		
	}
}
