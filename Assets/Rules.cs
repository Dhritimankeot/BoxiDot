using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{

    private TextMeshPro m_textMeshPro;

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
                SceneManager.LoadScene("Game");
            }

            counter += 1;
            yield return new WaitForSeconds(0.05f);

        }


    }
}
