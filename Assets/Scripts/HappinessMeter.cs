using UnityEngine;

public class HappinessMeter : MonoBehaviour
{
    [SerializeField] private Transform arrowTransform;
    [SerializeField] private float moveAmountCorrect = 15.0f;
    [SerializeField] private float moveAmountWrong = 8.0f;
    private float leftBound = -275.0f; // Adjust according to the bar position
    private float rightBound = 0f; // Adjust according to the bar position
    private int points = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Correct"))
                {
                    Debug.Log("The character is the correct one");
                    MoveArrow(moveAmountCorrect);
                    points++;
                    Debug.Log(points);
                }
                else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Wrong"))
                {
                    Debug.Log("The character is the wrong one");
                    MoveArrow(-moveAmountWrong);
                }
            }
        }
    }

    private void MoveArrow(float amount)
    {
        // Calculate the new position
        float newPositionX = arrowTransform.localPosition.x + amount;

        // Clamp the position to keep the arrow within the bounds
        newPositionX = Mathf.Clamp(newPositionX, leftBound, rightBound);

        // Apply the new position
        arrowTransform.localPosition = new Vector3(newPositionX, arrowTransform.localPosition.y, arrowTransform.localPosition.z);
    }
}