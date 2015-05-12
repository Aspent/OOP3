using System;

namespace Lab2
{
    class QualityEvaluator
    {
        #region Methods

        public int GetQualityCategory(Batch batch)
        {
            var defectiveCount = 0;
            var inTimeCount = 0;
            var extraTime = new TimeSpan();
            foreach (var product in batch.Products)
            {
                if(product.IsDefective)
                {
                    defectiveCount++;
                }
                if (product.TotalTimeSpent <= product.Description.StandardTime)
                {
                    inTimeCount++;
                }
                else
                {
                    extraTime += product.TotalTimeSpent - product.Description.StandardTime;
                }
            }
            var defectivePercent = (float)defectiveCount / batch.Products.Count;
            var inTimePercent = (float)inTimeCount / batch.Products.Count;  
                     
            if(defectivePercent < 0.03 && inTimePercent >= 0.8
                && extraTime <= new TimeSpan(0, 5 * (batch.Products.Count - inTimeCount), 0))
            {
                return 1;
            }
            if(defectivePercent < 0.05 && inTimePercent >= 0.75)
            {
                return 2;
            }
            return 3;
        }

        #endregion
    }
}
