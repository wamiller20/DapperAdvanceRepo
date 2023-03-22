namespace RepoExample.Entities
{
    public class Person : Person_Key, IPerson, IFullTable
    {
        private int personType;
        private int nameStyle;
        private int title;
        private int firstName;
        private int middleName;
        private int lastName;
        private int suffix;
        private int emailPromotion;
        private int additionalContactInfo;
        private int demographics;
        private int rowguid;
        private int modifiedDate;

        public int PersonType
        {
            get { return this.personType; }
            set
            {
                if (value != this.personType)
                {
                    this.personType = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int NameStyle
        {
            get { return this.nameStyle; }
            set
            {
                if (value != this.nameStyle)
                {
                    this.nameStyle = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int Title
        {
            get { return this.title; }
            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value != this.firstName)
                {
                    this.firstName = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (value != this.middleName)
                {
                    this.middleName = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int LastName
        {
            get { return this.lastName; }
            set
            {
                if (value != this.lastName)
                {
                    this.lastName = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int Suffix
        {
            get { return this.suffix; }
            set
            {
                if (value != this.suffix)
                {
                    this.suffix = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int EmailPromotion
        {
            get { return this.emailPromotion; }
            set
            {
                if (value != this.emailPromotion)
                {
                    this.emailPromotion = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int AdditionalContactInfo
        {
            get { return this.additionalContactInfo; }
            set
            {
                if (value != this.additionalContactInfo)
                {
                    this.additionalContactInfo = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int Demographics
        {
            get { return this.demographics; }
            set
            {
                if (value != this.demographics)
                {
                    this.demographics = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int Rowguid
        {
            get { return this.rowguid; }
            set
            {
                if (value != this.rowguid)
                {
                    this.rowguid = value;
                    this.PropertyHasChanged();
                }
            }
        }

        public int ModifiedDate
        {
            get { return this.modifiedDate; }
            set
            {
                if (value != this.modifiedDate)
                {
                    this.modifiedDate = value;
                    this.PropertyHasChanged();
                }
            }
        }
    }
}
