using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfStepByStep1
{
	public class AddressBookViewModel : ViewModelEntity
	{
		public AddressBookViewModel()
		{
		}
		
		protected ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
		
		protected Contact selectedContact = null;
		
		public ObservableCollection<Contact> Contacts
		{
			get { return contacts; }
			set { contacts = value; }
		}
		
		public Contact SelectedContact
		{
			get { return selectedContact; }
			set 
			{ 
				if(selectedContact != value)
				{
					selectedContact = value;
					NotifyPropertyChanged("SelectedContact");
				}
			}
		}
	}
}