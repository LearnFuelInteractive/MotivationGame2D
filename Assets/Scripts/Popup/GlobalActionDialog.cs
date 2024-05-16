using Assets.Scripts.Mediator;
using Assets.Scripts.Solution.GlobalSolutions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Popup
{
    public class GlobalActionDialog : IActionDialog
    {
        // Relation to mediator class
        // For now a relation to level manager.
        public IMediator Mediator;

        private void Start()
        {
            // Will retrieve all global solutions of children.
            Mediator = FindFirstObjectByType <LevelMediator>();
            // Load in all solutions present in scene.
            solutions = FindObjectsOfType<GlobalAction>().ToList();
            ProcessSolutions(solutions);
        }

        private void ProcessSolutions(List<GlobalAction> loadedSolutions)
        {
            List<GlobalAction> selectedSolutions = new List<GlobalAction>();
            string prefs = PlayerPrefs.GetString("SelectedLessonComponents");
            List<string> chosenSolutions = prefs.Split(";").ToList();

            loadedSolutions.ForEach(solution =>
            {
                // Check if the solution is selected in player preferences or is not a standard solution.
                // If no, delete them.
                if (solution.SolutionType.Equals("Standard") || chosenSolutions.Contains(solution.SolutionType))
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
