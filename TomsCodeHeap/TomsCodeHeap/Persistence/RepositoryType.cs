﻿// ========================================================================
// File:     RepositoryType.cs
// 
// Author:   $Author$
// Date:     $LastChangeDate$
// Revision: $Revision$
// ========================================================================
// Copyright [2011] [$Author$]
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
          
namespace CH.Froorider.Codeheap.Persistence
{
    /// <summary>
    /// Lists all types of <see cref="CH.Froorider.Codeheap.Persistence.IRepository"/> which can be created 
    /// using the <see cref="CH.Froorider.Codeheap.Persistence.RepositoryFactory"/>.
    /// </summary>
    public enum RepositoryType : int
    {
        /// <summary>
        /// Default value. Used when the enum was used but not initialized.
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Standard repository. Enities are stored using the local file system.
        /// </summary>
        FileRepository = 1
    }
}
