﻿using System;
using System.ComponentModel;
using System.Resources;

namespace CoV.Common.Infrastructure
{
    public class LocalizationAttribute : DescriptionAttribute
    {
        private readonly string _resourceKey;
        private readonly ResourceManager _resource;
        public LocalizationAttribute(string resourceKey, Type resourceType)
        {
            _resource = new ResourceManager(resourceType);
            _resourceKey = resourceKey;
        }

        public override string Description
        {
            get
            {
                string displayName = _resource.GetString(_resourceKey);
                return string.IsNullOrEmpty(displayName) ? string.Format("[[{0}]]", _resourceKey) : displayName;
            }
        }
    }
}
