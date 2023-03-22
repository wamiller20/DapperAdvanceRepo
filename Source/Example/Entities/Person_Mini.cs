namespace RepoExample.Entities
{
    public class Person_Mini : Person_Key
    {
        private int personType;
        private int nameStyle;
        private int title;
        private int firstName;

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
    }
}
