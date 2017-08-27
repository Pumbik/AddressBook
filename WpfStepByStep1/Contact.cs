using System;

namespace WpfStepByStep1
{
	public class Contact : ViewModelEntity
	{
		public Contact()
		{
		}
		
		protected string name;
		protected string email;
		protected string phonenumber;
		
		public string Name
		{
			get {return name;}
			set
			{
				if(name != value)
				{
					name = value;
					NotifyPropertyChanged("Name");
				}
			}
		}
		
		public string Email
		{
			get {return email;}
			set
			{
				if(email != value)
				{
					email = value;
					NotifyPropertyChanged("Email");
				}
			}
		}
		
		public string PhoneNumber
		{
			get {return phonenumber;}
			set
			{
				if(phonenumber != value)
				{
					phonenumber = value;
					NotifyPropertyChanged("PhoneNumber");
				}
			}
		}
	}
}