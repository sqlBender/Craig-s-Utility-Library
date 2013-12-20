﻿/*
Copyright (c) 2013 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Utilities.IO.FileSystem.Interfaces;
using Utilities.DataTypes;
using Utilities.DataTypes.Patterns.BaseClasses;
using Utilities.Configuration.Manager.Interfaces;
using System.Diagnostics.Contracts;
using Utilities.Configuration.Manager.Default;
using Utilities.IO;
using Utilities.Configuration.Manager.BaseClasses;
#endregion

namespace Utilities.Configuration
{
    /// <summary>
    /// JSON config base class
    /// </summary>
    /// <typeparam name="ClassType">Class type</typeparam>
    [Serializable]
    public abstract class JSONConfig<ClassType> : Config<ClassType>
        where ClassType : JSONConfig<ClassType>, new()
    {
        /// <summary>
        /// Constructor
        /// </summary>
        protected JSONConfig()
            : base(x => x.Deserialize<ClassType, string>(), x => x.Serialize<string, ClassType>())
        {
        }
    }
}