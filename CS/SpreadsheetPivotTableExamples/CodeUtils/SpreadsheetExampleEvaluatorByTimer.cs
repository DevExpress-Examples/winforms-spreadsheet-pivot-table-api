using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetPivotTableExamples
{
    #region SpreadsheetExampleEvaluatorByTimer
    public class SpreadsheetExampleEvaluatorByTimer : ExampleEvaluatorByTimer
    {
        public SpreadsheetExampleEvaluatorByTimer()
            : base()
        {
        }

        protected override ExampleCodeEvaluator GetExampleCodeEvaluator(ExampleLanguage language)
        {
            if (language == ExampleLanguage.VB)
                return new SpreadsheetVbExampleCodeEvaluator();
            return new SpreadsheetCSExampleCodeEvaluator();
        }
    }
    #endregion
}
