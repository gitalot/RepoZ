﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grr.Messages
{
	[System.Diagnostics.DebuggerDisplay("{GetRemoteCommand()}")]
	public class ListRepositoriesMessage : IMessage
	{
		private readonly string _repositoryFilter;

		public ListRepositoriesMessage(string repositoryFilter)
		{
			_repositoryFilter = repositoryFilter;
		}

		public void Execute(Repository[] repositories)
		{
			// nothing to do
		}

		public string GetRemoteCommand() => string.IsNullOrEmpty(_repositoryFilter) 
			? "list:.*" /* show all with RegEx pattern ".*" */
			: $"list:^{_repositoryFilter}$";

		public bool HasRemoteCommand => true;
		
	}
}