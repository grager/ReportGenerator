﻿/*
 *   Copyright (c) 2019 CAST
 *
 * Licensed under a custom license, Version 1.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License, accessible in the main project
 * source code: Empowerment.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using CastReporting.Domain;

namespace CastReporting.UI.WPF
{
    public class ApplicationItem
    {
        public ApplicationItem(Application app) {
            if (app.AdgVersion == null && app.Version != null)
                app.AdgVersion = app.Version;
            Application = app;
        }

        public Application Application { get; protected set; }

        public override string ToString() {
            return Application.DomainId + " / " + Application.Name;
        }
    }
}
