using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Transform targetLandmark;
    public Animator avatarAnimator;
    public InfoCardManager infoCardManager; 

    private bool hasReachedLandmark = false;

    void Start()
    {
        if (avatarAnimator == null)
        {
            UnityEngine.Debug.LogError("Avatar Animator not assigned to AvatarMovement script on " + gameObject.name);
        }
        if (targetLandmark == null)
        {
            UnityEngine.Debug.LogWarning("Target Landmark not assigned to AvatarMovement script on " + gameObject.name + ". Avatar will not move.");
        }
        if (infoCardManager == null) // NEW check
        {
            UnityEngine.Debug.LogError("Info Card Manager not assigned to AvatarMovement script on " + gameObject.name);
        }
    }

    void Update()
    {
        if (targetLandmark != null && !hasReachedLandmark)
        {
            Vector3 direction = targetLandmark.position - transform.position;
            direction.y = 0; // Keep movement on the horizontal plane

            // If close enough to the landmark
            if (direction.magnitude < 0.1f) // Adjust this threshold as needed
            {
                transform.position = targetLandmark.position; // Snap to target
                avatarAnimator.SetBool("IsWalking", false); // Stop walking animation

                // --- NEW: Trigger the dancing animation ---
                avatarAnimator.SetTrigger("StartDancing");

                hasReachedLandmark = true; // Mark as reached
                UnityEngine.Debug.Log("Avatar reached the landmark and started dancing!");
                
                if (infoCardManager != null)
                {
                    // Replace with actual landmark data later
                    infoCardManager.ShowInfoCard("Sheikh Zayed Grand Mosque", "It is one of the world's largest and most stunning mosques, built to embody Islamic messages of peace, tolerance, and diversity. Key features include its magnificent white marble, 82 domes, 1,000+ columns, 24-carat gold gilded chandeliers, and the world's largest hand-knotted carpet. It can accommodate over 40,000 worshippers and welcomes millions of visitors from all faiths.");
                }
            }
            else
            {
                // Move towards the target
                transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);

                // Make the avatar look at the target (only rotate Y axis)
                Quaternion lookRotation = Quaternion.LookRotation(direction.normalized);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

                // Set walking animation
                avatarAnimator.SetBool("IsWalking", true);
            }
        }
        // --- Removed the else if for hasReachedLandmark, as Animator handles the dance->idle transition ---
        // The Animator's "Has Exit Time" on the Dance -> Idle transition will take care of stopping movement.
        // If the avatar is already at the landmark, we don't want it to start walking again.
    }
}