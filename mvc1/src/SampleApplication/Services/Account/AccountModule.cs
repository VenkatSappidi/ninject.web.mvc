//-------------------------------------------------------------------------------
// <copyright file="AccountModule.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Remo Gloor (remo.gloor@gmail.com)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace SampleApplication.Services.Account
{
    using System.Web.Security;
    using Ninject.Modules;

    /// <summary>
    /// The ninject module for the account service.
    /// </summary>
    public class AccountModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            this.Bind<IMembershipService>().To<AccountMembershipService>();
            this.Bind<IFormsAuthenticationService>().To<FormsAuthenticationService>();
            this.Bind<MembershipProvider>().ToMethod(ctx => Membership.Provider);
        }
    }
}