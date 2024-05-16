using Assets.Scripts.Mediator;
using Assets.Scripts.Solution.GlobalSolutions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

namespace Assets.Scripts.Popup
{
    public class GlobalActionDialog : IActionDialog
    {
        // Relation to mediator class
        // For now a relation to level manager.
        public LevelMediator Mediator;
        public LessonComponentFactory LessonComponentFactory;

        private string selectedLessonComponentKey = "SelectedLessonComponents";

        private void Start()
        {
            LessonComponentFactory = new LessonComponentFactory();
            // Will retrieve all global solutions of children.
            Mediator = FindFirstObjectByType <LevelMediator>();
            // Load in all solutions present in scene.
            var list = FindObjectsOfType<GlobalAction>().ToList();
            ProcessSolutions(list);
        }

        private void ProcessSolutions(List<GlobalAction> loadedSolutions)
        {
            List<GlobalAction> selectedSolutions = new List<GlobalAction>();
            string lessonType = PlayerPrefs.GetString(selectedLessonComponentKey);
            loadedSolutions.ForEach(solution =>
            {
                // Check if the solution is selected in player preferences or is not a standard solution.
                // If no, delete them.
                Debug.LogWarning($"Solution key [{solution.Name}]");
                if (solution.SolutionType.Equals("Standard") || lessonType.Equals(solution.SolutionType))
                {
                    selectedSolutions.Add(solution);
                }
                else
                {
                    Destroy(solution.gameObject);
                }
                
            });

            solutions = selectedSolutions;
        }

        public void ShowPopupDialog()
        {
            // Should also process problem and student.
            Debug.Log("opened the showpopup method in global action dialog");
            ShowPopup();
        }
        public override void UpdateSolution()
        {
            // Get mediator class and assign it to global solution
            Debug.Log("No updates required");
        }

        public void DestroyPopup()
        {
            HidePopup();
        }
        
        public object GetMediator()
        {
            return Mediator;
        }

       
    }
}
