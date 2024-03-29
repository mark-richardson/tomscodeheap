﻿// ========================================================================
// File:     ISchedule.cs
// 
// Author:   $Author$
// Date:     $LastChangedDate: 2010-09-14 11:10:11 +0200 (Di, 14 Sep 2010) $
// Revision: $Revision: 72 $
// ========================================================================
// Copyright [2009] [$Author$]
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ========================================================================

using System;
using System.Threading;

namespace CH.Froorider.Codeheap.Threading
{
	/// <summary>
	/// This interface declares the offered functionality by a sheduled object.
	/// A scheduled object can be managed by a Scheduler. The client using this
	/// schedule defines when to be triggered.
	/// An <see cref="AutoResetEvent"/> acts as a trigger. This signal can be used by the client to
	/// wake up.
	/// </summary>
	public interface ISchedule
	{
		#region Properties

		/// <summary>
		/// Gets the <see cref="IScheduler"/> that this <see cref="ISchedule"/> belongs to.
		/// </summary>
		IScheduler Owner
		{
			get;
		}

		/// <summary>
		/// Gets the period of this <see cref="ISchedule"/>.
		/// </summary>
		TimeSpan Period
		{
			get;
		}

		/// <summary>
		/// Gets the signal that a client of this <see cref="ISchedule"/>
		/// waits for to be signaled periodically.
		/// </summary>
		AutoResetEvent ScheduleSignal
		{
			get;
		}

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="ISchedule"/> is currently active.
		/// </summary>
		/// <remarks>
		/// If you enable the Schedule, the NextDueTime is set to <see cref="DateTime.Now"/> + <see cref="Period"/>.
		/// If you disable the Schedule, the NextDueTime is set to <see cref="DateTime.MaxValue"/>.
		/// </remarks>
		bool Enabled
		{
			get;

			set;
		}

		/// <summary>
		/// Gets the next time when <see cref="ScheduleSignal"/> will be <see cref="M:AutoResetEvent.Set"/>;
		/// or <see cref="DateTime.MaxValue"/> if <see cref="Enabled"/> is <see langword="false"/>.
		/// </summary>
		DateTime NextDueTime
		{
			get;
		}

		#endregion Properties
	}
}
