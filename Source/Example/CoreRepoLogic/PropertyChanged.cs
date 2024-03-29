﻿using System.Runtime.CompilerServices;

namespace RepoExample.CoreRepoLogic
{
    public abstract class PropertyChanged
    {
        public PropertyChanged()
        {
            ChangedProperties = new List<string>();
        }
        public List<string> ChangedProperties { get; internal protected set; }
        protected internal virtual void PropertyHasChanged([CallerMemberName] string propertyName = "")
        {
            if (ChangedProperties.Contains(propertyName) == false) { ChangedProperties.Add(propertyName); }
        }

        public virtual void RemovePropertyFromBeingUpdated(string propertyName)
        {
            if (ChangedProperties.Contains(propertyName)) { ChangedProperties.Remove(propertyName); }
        }

        public virtual void ResetPropertyChanges()
        {
            ChangedProperties.Clear();
        }
    }
}
