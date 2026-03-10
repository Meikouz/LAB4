using System;
using System.Collections.Generic;

namespace LAB4
{
    public class BouquetDirector
    {
        private BouquetBuilder builder;
        private List<Action> steps;
        private List<string> stepDescriptions;
        private int currentStep;

        public int CurrentStep => currentStep;
        public int TotalSteps => steps?.Count ?? 0;

        public void SetBuilder(BouquetBuilder builder)
        {
            this.builder = builder;
            Reset();
        }

        public void Reset()
        {
            if (builder == null) return;

            builder.CreateBouquet();
            currentStep = 0;

            steps = new List<Action>
            {
                builder.SetName,
                builder.AddMainFlowers,
                builder.AddSecondaryFlowers,
                builder.AddGreenery,
                builder.SetWrapping,
                builder.SetRibbon,
                builder.SetCard,
                builder.SetDecor
            };

            stepDescriptions = new List<string>
            {
                "Крок 1: Задано назву букета",
                "Крок 2: Додано основні квіти",
                "Крок 3: Додано додаткові квіти",
                "Крок 4: Додано зелень",
                "Крок 5: Обрано упаковку",
                "Крок 6: Додано стрічку",
                "Крок 7: Додано листівку",
                "Крок 8: Додано декор"
            };
        }

        public string BuildStep()
        {
            if (builder == null)
                return "Будівельник не вибраний.";

            if (currentStep >= steps.Count)
                return "Букет уже повністю сформовано.";

            steps[currentStep].Invoke();
            string result = stepDescriptions[currentStep];
            currentStep++;
            return result;
        }

        public List<string> BuildAll()
        {
            List<string> result = new List<string>();

            while (!IsFinished())
            {
                result.Add(BuildStep());
            }

            return result;
        }

        public bool IsFinished()
        {
            return steps != null && currentStep >= steps.Count;
        }

        public Bouquet GetBouquet()
        {
            return builder?.GetBouquet();
        }
    }
}