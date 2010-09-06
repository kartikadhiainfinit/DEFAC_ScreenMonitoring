using System;
using System.Collections;
using System.Windows.Forms;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Dient zum Sortieren von ListViewItems.
	/// </summary>
	public class ListViewColumnSorter : IComparer
	{
		#region----------------------------- Member Variables -------------------------------------

		// Stringvergleicher
		private CaseInsensitiveComparer _comparer;

		// Parameter
		private int _sortColumn;      // Spaltenindex
		private SortOrder _sortOrder; // Sortierreihenfolge

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Sortierobjekt
		/// </summary>
		public ListViewColumnSorter()
		{
			// Stringvergleicher initialisieren
			_comparer = new CaseInsensitiveComparer();

			// Parameter initialisieren
			_sortOrder = SortOrder.None;
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// Spaltenindex
		/// </summary>
		public int SortColumn
		{
			set
			{
				_sortColumn = value;
			}
			get
			{
				return _sortColumn;
			}
		}

		/// <summary>
		/// Sortierreihenfolge
		/// </summary>
		public SortOrder SortOrder
		{
			set
			{
				_sortOrder = value;
			}
			get
			{
				return _sortOrder;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		/// <summary>
		/// vergleicht übergebene ListViewItems nach angegebener Spalte
		/// </summary>
		public int Compare(object x, object y)
		{
			// ListviewItems referenzieren
			ListViewItem itemX = (ListViewItem)x;
			ListViewItem itemY = (ListViewItem)y;

			// angegebene Spalte vergleichen
			int compareResult = _comparer.Compare(itemX.SubItems[_sortColumn].Text,
				itemY.SubItems[_sortColumn].Text);

			// je nach eingestellter Sortierreihenfolge, Ergebnis zurückgeben
			switch (_sortOrder)
			{
				case SortOrder.Ascending:
					return compareResult;
				case SortOrder.Descending:
					return -compareResult;
			}
			return 0;
		}

		#endregion
	}
}
