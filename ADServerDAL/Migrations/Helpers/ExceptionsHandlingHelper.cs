﻿using System;
using System.Collections.Generic;

namespace ADServerDAL.Helpers
{
	public static class ExceptionsHandlingHelper
	{
		/// <summary>
		/// Zbudowanie hierarchii wyjątków (wyjątki zagnieżdżone)
		/// </summary>
		/// <param name="current"></param>
		/// <param name="hierarchy"></param>
		public static void HierarchizeError(Exception current, ref List<Exception> hierarchy)
		{
			hierarchy.Add(current);
			if (current.InnerException != null)
			{
				HierarchizeError(current.InnerException, ref hierarchy);
			}
		}
	}
}