using DevExpress.Spreadsheet;

namespace SpreadsheetPivotTableExamples
{
    public static class PivotFieldActions
    {
        static void AddFieldToAxis(IWorkbook workbook)
        {
            #region #AddToAxis
            Worksheet sourceWorksheet = workbook.Worksheets["Data1"];
            Worksheet worksheet = workbook.Worksheets.Add();
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Create a pivot table.
            PivotTable pivotTable = worksheet.PivotTables.Add(sourceWorksheet["A1:D41"], worksheet["B2"]);

            // Add the "Product" field to the row axis area.
            pivotTable.RowFields.Add(pivotTable.Fields["Product"]);
            // Add the "Category" field to the column axis area.
            pivotTable.ColumnFields.Add(pivotTable.Fields["Category"]);
            // Add the "Sales" field to the data area and specify the custom field name.
            pivotTable.DataFields.Add(pivotTable.Fields["Sales"], "Sales(Sum)");
            // Add the "Region" field to the filter area.
            pivotTable.PageFields.Add(pivotTable.Fields["Region"]);

            // Specify the number format for the "Sales" field.
            pivotTable.Fields["Sales"].NumberFormat = @"_([$$-409]* #,##0.00_);_([$$-409]* (#,##0.00);_([$$-409]* "" - ""??_);_(@_)";
            #endregion #AddToAxis
        }

        static void InsertFieldToAxis(IWorkbook workbook)
        {
            #region #InsertAtTop
            Worksheet worksheet = workbook.Worksheets["Report1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Access the pivot table by its name in the collection.
            PivotTable pivotTable = worksheet.PivotTables["PivotTable1"];

            // Insert the "Region" field at the top of the row axis area.
            pivotTable.RowFields.Insert(0, pivotTable.Fields["Region"]);
            #endregion #InsertAtTop
        }

        static void MoveFieldToAxis(IWorkbook workbook)
        {
            #region #MoveToAxis
            Worksheet worksheet = workbook.Worksheets["Report1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Access the pivot table by its name in the collection.
            PivotTable pivotTable = worksheet.PivotTables["PivotTable1"];

            // Move the "Region" field to the column axis area.
            pivotTable.ColumnFields.Add(pivotTable.Fields["Region"]);
            #endregion #MoveToAxis
        }

        static void MoveFieldUp(IWorkbook workbook)
        {
            #region #MoveUp
            Worksheet worksheet = workbook.Worksheets["Report3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Access the pivot table by its name in the collection.
            PivotTable pivotTable = worksheet.PivotTables["PivotTable1"];

            // Move the "Category" field one position up in the row area.
            pivotTable.RowFields["Category"].MoveUp();
            #endregion #MoveUp
        }

        static void MoveFieldDown(IWorkbook workbook)
        {
            #region #MoveDown
            Worksheet worksheet = workbook.Worksheets["Report3"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Access the pivot table by its name in the collection.
            PivotTable pivotTable = worksheet.PivotTables["PivotTable1"];

            // Move the "Region" field one position down in the row area.
            pivotTable.RowFields["Region"].MoveDown();
            #endregion #MoveDown
        }

        static void RemoveFieldFromAxis(IWorkbook workbook)
        {
            #region #RemoveFromAxis
            Worksheet worksheet = workbook.Worksheets["Report1"];
            workbook.Worksheets.ActiveWorksheet = worksheet;

            // Access the pivot table by its name in the collection.
            PivotTable pivotTable = worksheet.PivotTables["PivotTable1"];

            // Remove the "Product" field from the row axis area.
            pivotTable.RowFields.Remove(pivotTable.RowFields["Product"]);
            #endregion #RemoveFromAxis
        }
    }
}

