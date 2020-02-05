﻿using System.Collections.Generic;

namespace AbpHelper.Models
{
    public class EntityInfo
    {
        public EntityInfo(string @namespace, string className, string? baseType, string? primaryKey)
        {
            Namespace = @namespace;
            ClassName = className;
            BaseType = baseType;
            PrimaryKey = primaryKey;
        }

        public string Namespace { get; }
        public string ClassName { get; }
        public string? BaseType { get; }
        public string? PrimaryKey { get; set; }
        public List<PropertyInfo> Properties { get; } = new List<PropertyInfo>();
    }

    public class PropertyInfo
    {
        public PropertyInfo(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public string Type { get; }
        public string Name { get; }
    }
}