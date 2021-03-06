//
// mTouch-PDFReader library
// DocumentNoteManager.cs (DDocument note manager)
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2012 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using mTouchPDFReader.Library.Interfaces;
using mTouchPDFReader.Library.Data.Objects;

namespace mTouchPDFReader.Library.Managers
{
	public class DocumentNoteManager : IDocumentNoteManager
	{
		protected DocumentNoteManager()	{}

		#region IDocumentNoteManager members
		public virtual DocumentNote GetNew(int docId, string note)
		{
			return new DocumentNote {
				Id = -1,
				DocId = docId,
				Note = note
			};
		}

		public virtual DocumentNote Load(int docId)
		{
			return new DocumentNote {
				Id = -1, DocId = docId, Note = string.Empty
			};
		}

		public virtual void Save(DocumentNote note)
		{
			// Noting
		}		
		#endregion
	}
}
