using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections; // Required for Coroutines

public class FadeManager : MonoBehaviour
{
    public CanvasGroup fadePanelCanvasGroup; // Drag your FadePanel's Canvas Group here
    public float fadeDuration = 1.5f; // How long the fade takes (in seconds)

    // Reference to the scene to load after fading out
    private string sceneToLoad;

    void Start()
    {
        if (fadePanelCanvasGroup == null)
        {
            UnityEngine.Debug.LogError("Fade Panel Canvas Group not assigned to FadeManager on " + gameObject.name);
        }
        // Start faded in (transparent)
        if (fadePanelCanvasGroup != null)
        {
            fadePanelCanvasGroup.alpha = 0f;
            fadePanelCanvasGroup.blocksRaycasts = false; // Allow clicks through transparent panel
        }

        // If you want a fade-in effect when the scene loads (optional, but good practice)
        // StartCoroutine(FadeIn());
    }

    // Call this method to fade out to black and then load a scene
    public void FadeOutAndLoadScene(string sceneName)
    {
        if (fadePanelCanvasGroup == null) return;

        sceneToLoad = sceneName;
        fadePanelCanvasGroup.blocksRaycasts = true; // Block clicks during fade
        StartCoroutine(PerformFade(0f, 1f, () => SceneManager.LoadScene(sceneToLoad)));
    }

    // Call this method to fade in from black (e.g., when a new scene loads)
    public IEnumerator FadeIn()
    {
        if (fadePanelCanvasGroup == null) yield break;

        fadePanelCanvasGroup.alpha = 1f; // Start fully opaque
        fadePanelCanvasGroup.blocksRaycasts = true; // Block clicks during fade
        yield return StartCoroutine(PerformFade(1f, 0f, () => fadePanelCanvasGroup.blocksRaycasts = false));
    }

    // Generic coroutine for fading
    private IEnumerator PerformFade(float startAlpha, float endAlpha, System.Action onComplete = null)
    {
        float timer = 0f;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            fadePanelCanvasGroup.alpha = Mathf.Lerp(startAlpha, endAlpha, timer / fadeDuration);
            yield return null; // Wait for next frame
        }
        fadePanelCanvasGroup.alpha = endAlpha; // Ensure it ends at the exact value

        onComplete?.Invoke(); // Execute callback if provided
    }
}