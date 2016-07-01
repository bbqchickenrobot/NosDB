﻿//+Copyright (c) 2014, Kevin Thompson
//+All rights reserved.
//+
//+Redistribution and use in source and binary forms, with or without
//+modification, are permitted provided that the following conditions are met:
//+
//+1. Redistributions of source code must retain the above copyright notice, this
//+   list of conditions and the following disclaimer. 
//+2. Redistributions in binary form must reproduce the above copyright notice,
//+   this list of conditions and the following disclaimer in the documentation
//+   and/or other materials provided with the distribution.
//+
//+THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//+ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//+WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//+DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
//+ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//+(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
//+LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
//+ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
//+(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//+SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alachisoft.NosDB.Common.Security.SSPI
{
    /// <summary>
    /// Stores information about a particular security package.
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public class SecPkgInfo
    {
        /// <summary>
        /// The packages capabilities and options.
        /// </summary>
        public SecPkgCapability Capabilities;

        /// <summary>
        /// The package's version number.
        /// </summary>
        public short Version;

        /// <summary>
        /// The package's Id when used in RPC contexts.
        /// </summary>
        public short RpcId;

        /// <summary>
        /// The maximum size, in bytes, of tokens generated by the package.
        /// </summary>
        public int MaxTokenLength;

        /// <summary>
        /// The human-readable name of the package.
        /// </summary>
        [MarshalAs( UnmanagedType.LPWStr )]
        public string Name;

        /// <summary>
        /// A short description of the package.
        /// </summary>
        [MarshalAs( UnmanagedType.LPWStr )]
        public string Comment;
    }
}