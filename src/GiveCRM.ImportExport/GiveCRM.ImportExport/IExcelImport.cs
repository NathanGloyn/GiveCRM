using System.Collections.Generic;
using System.IO;

namespace GiveCRM.ImportExport
{
    public interface IExcelImport
    {
        void Open(Stream streamToProcess, ExcelFileType fileType, bool hasHeaderRow);
        IEnumerable<IEnumerable<string>> GetRows(int sheetIndex, bool includeHeaderRow);
        IEnumerable<IDictionary<string, object>> GetRowsAsKeyValuePairs(int sheetIndex);
    }
}