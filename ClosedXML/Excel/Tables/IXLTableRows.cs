// Keep this file CodeMaid organised and cleaned
using System.Collections.Generic;

namespace ClosedXML.Excel
{
    public interface IXLTableRows : IEnumerable<IXLTableRow>
    {
        IXLStyle Style { get; set; }

        /// <summary>
        /// Adds a table row to this group.
        /// </summary>
        /// <param name="tableRow">The row table to add.</param>
        void Add(IXLTableRow tableRow);

        /// <summary>
        /// Returns the collection of cells.
        /// </summary>
        IXLCells Cells();

        /// <summary>
        /// Returns the collection of cells that have a value.
        /// </summary>
        IXLCells CellsUsed();

        /// <summary>
        /// Returns the collection of cells that have a value.
        /// </summary>
        /// <param name="options">The options to determine whether a cell is used.</param>
        IXLCells CellsUsed(XLCellsUsedOptions options);

        /// <summary>
        /// Clears the contents of these rows.
        /// </summary>
        /// <param name="clearOptions">Specify what you want to clear.</param>
        IXLTableRows Clear(XLClearOptions clearOptions = XLClearOptions.All);

        void Delete();

        void Select();
    }
}
