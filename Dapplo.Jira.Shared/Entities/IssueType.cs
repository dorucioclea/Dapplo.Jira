﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2015-2016 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Jira
// 
//  Dapplo.Jira is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Jira is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Jira. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#region using

using System;
using System.Runtime.Serialization;

#endregion

namespace Dapplo.Jira.Entities
{
	/// <summary>
	///     IssueType information
	/// </summary>
	[DataContract]
	public class IssueType : BaseProperties<long>
	{
		/// <summary>
		/// Description of the issue type
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; }

		/// <summary>
		/// URL to the icon for the issue type
		/// </summary>
		[DataMember(Name = "iconUrl")]
		public Uri IconUri { get; set; }

		/// <summary>
		/// Is the issue type a sub task?
		/// </summary>
		[DataMember(Name = "subtask")]
		public bool IsSubTask { get; set; }

		/// <summary>
		/// Name of the issue type
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }
	}
}